using LAB2.controllers;
using LAB2.models;
using LAB2_3_Base.controllers;
using LAB2_3_Base.models;
using System;
using System.Net.Sockets;
using System.Threading;


namespace LAB2.views
{
    class ServerMainThread
    {
        private static Socket m_Socket;
        private static bool closed = false;

        public static void Init()
        {
            Console.WriteLine("[INFO] Initialization started!");
            HostSettings.InitCmdPrefix();
            Console.WriteLine("[INFO] CmdPrefix initialized!");
            DataBaseControl.LoadDataBase();
            Console.WriteLine("[INFO] DataBase initialized!");


            m_Socket = new Socket(HostSettings.ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            
            m_Socket.Bind(HostSettings.ipEndPoint);
            m_Socket.Listen(100);
            

            Console.WriteLine("[INFO] Initialization finished!");
        }

        public static void Run()
        {
            Thread cmdListener = new Thread(ServerMainThread.CmdListener);
            cmdListener.Start();

            Socket newClient = null;
            string msgAll = String.Empty;
            string msg = String.Empty;
            string cmd = String.Empty;
            while (!closed)
            {
                try
                {
                    newClient = m_Socket.Accept();
                } catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }





                try {
                    msgAll = SocketIO.ReceiveAll(newClient);
                    msg = msgAll.Substring(CmdPrefix.commandPrefixSize);
                    cmd = msgAll.Substring(0, CmdPrefix.commandPrefixSize);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                




                if(cmd == CmdPrefix.authCommandPrefix)
                {
                    UserDescriptor tmpUser = SocketIO.Diserialize<UserDescriptor>(msg);

                    Console.WriteLine("[INFO/AUTH] Accepting connection with " + tmpUser.Name);
                    
                    if (DataBaseControl.AuthUser(tmpUser))
                    {
                        Console.WriteLine("[INFO/AUTH] Success!");

                        SocketIO.SendAll(newClient, CmdPrefix.authSuccessCommandPrefix + "Access allowed!");
                        ClientThread client = new ClientThread(newClient, tmpUser, HostSettings.defaultChannelId);
                        DataBaseControl.AddClientToChannel(HostSettings.defaultChannelId, tmpUser, newClient);
                        DataBaseControl.SendLast_N_MessagesToThisUser(HostSettings.defaultChannelId, newClient, 10);
                        Thread thr = new Thread(client.Run);
                        thr.Start();
                    }
                    else
                    {
                        Console.WriteLine("[INFO/AUTH] Fail!");
                        SocketIO.SendAll(newClient, CmdPrefix.authErrorCommandPrefix + "Access denied!");

                    }
                }

                if(cmd == CmdPrefix.registerCommandPrefix)
                {
                    UserDescriptor tmpUser = SocketIO.Diserialize<UserDescriptor>(msg);

                    Console.WriteLine("[INFO/REG] Accepting connection with " + tmpUser.Name);

                    if (DataBaseControl.RegisterNewUser(tmpUser))
                    {
                        Console.WriteLine("[INFO/REG] Success!");

                        SocketIO.SendAll(newClient, CmdPrefix.registerSuccessCommandPrefix + "Register success!");
                        ClientThread client = new ClientThread(newClient, tmpUser, HostSettings.defaultChannelId);
                        DataBaseControl.AddClientToChannel(HostSettings.defaultChannelId, tmpUser, newClient);
                        DataBaseControl.SendLast_N_MessagesToThisUser(HostSettings.defaultChannelId, newClient, 10);
                        Thread thr = new Thread(client.Run);
                        thr.Start();

                    }
                    else
                    {
                        Console.WriteLine("[INFO/REG] Fail!");
                        SocketIO.SendAll(newClient, CmdPrefix.registerErrorCommandPrefix + "This user already exists! Change name!");
                    }
                }

            }

        }


       

        public static void CmdListener()
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(input == "/stop")
                {
                    Console.WriteLine("[INFO] Stopping... Press any key...");
                    closed = true;
                    m_Socket.Close();
                    Console.ReadKey();
                    Environment.Exit(0);

                }
            }

        }
    }
}
