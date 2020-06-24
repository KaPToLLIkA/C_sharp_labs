using LAB2.controllers;
using LAB2.models;
using LAB2_3_Base.controllers;
using LAB2_3_Base.models;
using System;
using System.Net.Sockets;

namespace LAB2.views
{
    class ClientThread
    {
        private Socket m_Socket;
        private UserDescriptor m_User;
        private Int32 m_channelId;
        
        public ClientThread(Socket clientSocket, UserDescriptor user, Int32 channelId)
        {
            m_Socket = clientSocket;
            m_User = user;
            m_channelId = channelId;
        }
        public void Run()
        {
            Console.WriteLine("[INFO/CLIENT " + m_User.Name + " ] Thread started!");
            bool connected = true;
            string allMsg;
            string msg;
            string cmd;

            while(connected && SocketIO.IsSocketStillConnected(m_Socket))
            {
                allMsg = SocketIO.ReceiveAll(m_Socket);
                msg = allMsg.Substring(CmdPrefix.commandPrefixSize);
                cmd = allMsg.Substring(0, CmdPrefix.commandPrefixSize);
                
                if(cmd == CmdPrefix.sendMessageCommandPrefix)
                {
                    Console.WriteLine("[INFO/CLIENT " + m_User.Name + " ] SEND MESSAGE: " + msg);
                    DataBaseControl.SendMessage(m_channelId, SocketIO.Diserialize<MessageDescriptor>(msg));
                }

                if(cmd == CmdPrefix.setChannelCommandPrefix)
                {
                    Console.WriteLine("[INFO/CLIENT " + m_User.Name + " ] SET CHANNEL: " + msg);
                    msg = msg.Replace(" ", "");
                    Int32 newChannelId = Convert.ToInt32(msg);
                    DataBaseControl.ReplaceClientToAnotherChannel(m_channelId, newChannelId, m_User, m_Socket);
                    m_channelId = newChannelId;
                    DataBaseControl.SendLast_N_MessagesToThisUser(m_channelId, m_Socket, 10);
                }

                if(cmd == CmdPrefix.closeConnectionCommandPrefix)
                {
                    DataBaseControl.RemoveClientFromChannel(m_channelId, m_User);
                    connected = false;
                }
            }
            Console.WriteLine("[INFO/CLIENT " + m_User.Name + " ] Thread ended!");
        }


        

        
    }
}
