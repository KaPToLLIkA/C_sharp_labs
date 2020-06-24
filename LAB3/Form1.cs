using LAB2_3_Base.controllers;
using LAB2_3_Base.models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public static Dispatcher d;
        public Form1()
        {
            ClientSettings.InitSettings();
            InitializeComponent();

            for (int i = 1; i <= ClientSettings.maxChannelsCount; ++i)
                this.ChannelBox.Items.Add("Channel id: " + Convert.ToString(i));
            this.ChannelBox.SelectedIndex = 0;


            this.sendMsgButton.Enabled = false;
            d = Dispatcher.CurrentDispatcher;
        }



        public void socketListener()
        {
             
            while(Data.connectedToServer)
            {
                string msgAll = SocketIO.ReceiveAll(Data.serverSocket);
                string msg = msgAll.Substring(CmdPrefix.commandPrefixSize);
                string cmd = msgAll.Substring(0, CmdPrefix.commandPrefixSize);


                if (cmd == CmdPrefix.registerSuccessCommandPrefix)
                {

                    d.Invoke(new Action(() =>
                    {
                        this.serverAnswers.Items.Add(msg);
                        this.buttonAuth.Text = "LOGOUT";
                        this.buttonReg.Enabled = false;
                        this.sendMsgButton.Enabled = true;
                        this.msgList.Items.Clear();
                    }));
                    Data.authorizedOnServer = true;
                    Data.loggedUserName = this.inputName.Text;
                }


                if (cmd == CmdPrefix.registerErrorCommandPrefix)
                {
                    d.Invoke(new Action(() => this.serverAnswers.Items.Add(msg)));
                    Data.authorizedOnServer = false;
                }

                if (cmd == CmdPrefix.authSuccessCommandPrefix)
                {

                    d.Invoke(new Action(() =>
                    {
                        this.serverAnswers.Items.Add(msg);
                        this.buttonAuth.Text = "LOGOUT";
                        this.buttonReg.Enabled = false;
                        this.sendMsgButton.Enabled = true;
                        this.msgList.Items.Clear();
                    }));
                    Data.authorizedOnServer = true;
                    Data.loggedUserName = this.inputName.Text;
                }
                if (cmd == CmdPrefix.authErrorCommandPrefix)
                {
                   
                    Data.authorizedOnServer = false;
                    d.Invoke(new Action(() => this.serverAnswers.Items.Add(msg)));
                }

                if (cmd == CmdPrefix.msgListCommandPrefix)
                {
                    List<MessageDescriptor> msgs = SocketIO.Diserialize<List<MessageDescriptor>>(msg);
                    d.Invoke(new Action(() => { 
                        foreach (MessageDescriptor desc in msgs)
                            this.msgList.Items.Add($"[ {desc.DateTime} ] {desc.User} : {desc.Text}"); 
                    }));
                }

                if (cmd == CmdPrefix.msgCommandPrefix)
                {
                    MessageDescriptor desc = SocketIO.Diserialize<MessageDescriptor>(msg);
                    d.Invoke(new Action(() => this.msgList.Items.Add($"[ {desc.DateTime} ] {desc.User} : {desc.Text}")));
                }

            }

            Data.listenerStarted = false;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            
            connectToServer();
            if (!Data.connectedToServer)
                MessageBox.Show("Can't connect to server!", "Error", MessageBoxButtons.OK);
            

            if (Data.connectedToServer)
            {
                if(!Data.listenerStarted)
                {
                    Thread thr = new Thread(this.socketListener);
                    thr.Start();
                }

                SocketIO.SendAll(
                    Data.serverSocket,
                    CmdPrefix.registerCommandPrefix + SocketIO.Serialize(
                        new UserDescriptor(this.inputName.Text, this.inputPassword.Text)
                        )
                    );


            }

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (Data.authorizedOnServer)
            {
                SocketIO.SendAll(Data.serverSocket, CmdPrefix.closeConnectionCommandPrefix);
                Data.authorizedOnServer = false;
                Data.connectedToServer = false;
                this.buttonReg.Enabled = true;
                this.sendMsgButton.Enabled = false;
                this.buttonAuth.Text = "LOGIN";

            }
            else
            {

                connectToServer();
                if (!Data.connectedToServer)
                    MessageBox.Show("Can't connect to server!", "Error", MessageBoxButtons.OK);


                if (Data.connectedToServer)
                {
                    if (!Data.listenerStarted)
                    {
                        Thread thr = new Thread(this.socketListener);
                        thr.Start();
                    }

                    SocketIO.SendAll(
                        Data.serverSocket,
                        CmdPrefix.authCommandPrefix + SocketIO.Serialize(
                            new UserDescriptor(this.inputName.Text, this.inputPassword.Text)
                            )
                        );
                    
                }
            }
        }

        private void ChannelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;

            if(Data.authorizedOnServer)
            {
                if(Data.currentChannel != box.SelectedIndex)
                {
                    Data.currentChannel = box.SelectedIndex;
                    SocketIO.SendAll(Data.serverSocket, CmdPrefix.setChannelCommandPrefix + Convert.ToString(Data.currentChannel));
                    this.msgList.Items.Clear();
                    
                }
            }
        }

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            if(Data.authorizedOnServer)
            {
                if(this.inputMsg.Text.Length > 0)
                SocketIO.SendAll(
                    Data.serverSocket, 
                    CmdPrefix.sendMessageCommandPrefix + SocketIO.Serialize(
                        MessageDescriptor.NewMessageNoTime(new UserDescriptor(Data.loggedUserName), this.inputMsg.Text)
                        )
                    );


            }
        }


        private void connectToServer()
        {
            try
            {
                Data.ipServer = new IPEndPoint(new IPAddress(parseIP(this.inputIP.Text)), ClientSettings.port);
                if(!Data.parseIPsuccess)
                {
                    Data.connectedToServer = false;
                    return;
                }
                Data.serverSocket = new Socket(Data.ipServer.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (Exception ex)
            {
                Data.connectedToServer = false;
                return;
            }

            try
            {
                Data.serverSocket.Connect(Data.ipServer);
            }
            catch(Exception ex)
            {
                Data.connectedToServer = false;
                return;
            }
            Data.connectedToServer = true;
        }

        private static byte[] parseIP(string strIP)
        {
            byte[] ip = { 0, 0, 0, 0};
            Data.parseIPsuccess = true;

            for(int i = 0; i < 4; ++i)
            {
                int idx = strIP.IndexOf('.');
                if (idx < 0) idx = strIP.Length;
                try
                {
                    ip[i] = Convert.ToByte(strIP.Substring(0, idx));
                } catch(Exception e)
                {
                    MessageBox.Show("Please, type correct ip address!", "Wrong IP", MessageBoxButtons.OK);
                    Data.parseIPsuccess = false;
                    break;
                }

                try
                {
                    strIP = strIP.Substring(idx + 1);
                }
                catch(Exception e)
                {

                }
            }

            return ip;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
