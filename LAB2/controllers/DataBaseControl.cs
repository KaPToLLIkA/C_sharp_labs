using LAB2.models;
using LAB2_3_Base.controllers;
using LAB2_3_Base.models;
using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace LAB2.controllers
{
    class DataBaseControl
    {
        private static DataBase m_db;
        private static object m_asyncAccessContolToChannels = new object();
        private static object m_asyncAccessContolToUsers = new object();
        public static void LoadDataBase()
        {
            
            m_db = new DataBase(HostSettings.maxChannelsCount);
        }


        public static void SendMessage(Int32 channelId, MessageDescriptor msg)
        {
            lock(m_asyncAccessContolToChannels)
            {
                msg.DateTime = DateTime.Now;
                m_db.AddMessageToChannel(channelId, msg);


                string resultMsg = CmdPrefix.msgCommandPrefix + SocketIO.Serialize(msg);
                
                foreach (KeyValuePair<UserDescriptor, Socket> pair in m_db.ClientsInChannels[channelId])
                {
                    if (SocketIO.IsSocketStillConnected(pair.Value))
                        SocketIO.SendAll(pair.Value, resultMsg);
                    else
                        m_db.RemoveClientFromChannel(channelId, pair.Key);
                }

            }
        }

        public static void SendLast_N_MessagesToThisUser(Int32 channelId, Socket userSocket, Int32 msgCount)
        {
            lock(m_asyncAccessContolToChannels)
            {
             
                
                if(SocketIO.IsSocketStillConnected(userSocket)) 
                   SocketIO.SendAll(userSocket, CmdPrefix.msgListCommandPrefix + SocketIO.Serialize(m_db.Channels[channelId].GetNLastMessages(msgCount)));
            }
        }

        public static void AddClientToChannel(Int32 channelId, UserDescriptor user, Socket socket)
        {
            lock (m_asyncAccessContolToChannels)
            {
                m_db.AddClientToChannel(channelId, user, socket);
            }
        }

        public static void RemoveClientFromChannel(Int32 channelId, UserDescriptor user)
        {
            lock(m_asyncAccessContolToChannels)
            {
                m_db.RemoveClientFromChannel(channelId, user);
            }

        }


        public static void ReplaceClientToAnotherChannel(Int32 oldChannelId, Int32 newChannelId, UserDescriptor user, Socket userSocket)
        {
            lock(m_asyncAccessContolToChannels)
            {
                m_db.ReplaceClientToAnotherChannel(oldChannelId, newChannelId, user, userSocket);
            }
        }

        public static bool RegisterNewUser(UserDescriptor newUser)
        {
            lock (m_asyncAccessContolToUsers)
            {
                return m_db.RegisterUser(newUser);
            }
        }

        public static bool AuthUser(UserDescriptor user)
        {
            lock (m_asyncAccessContolToUsers)
            {
                return m_db.AuthValidation(user);
            }
        }

        public static void UnloadDataBase()
        {
            
        }

    }
}
