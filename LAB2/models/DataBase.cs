using LAB2_3_Base.models;
using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace LAB2.models
{
    [Serializable]
    class DataBase
    {
        private List<Dictionary<UserDescriptor, Socket>> m_ClientsInChannels = new List<Dictionary<UserDescriptor, Socket>>();
        private List<Channel> m_Channels = new List<Channel>();
        private List<UserDescriptor> m_Users = new List<UserDescriptor>();
        private Int32 m_MaxChannelsCount = 0;

        public List<Channel> Channels { get => m_Channels; }
        public List<UserDescriptor> Users { get => m_Users; }
        public Int32 MaxChannelsCount { get => m_MaxChannelsCount; }
        public List<Dictionary<UserDescriptor, Socket>> ClientsInChannels { get => m_ClientsInChannels; }

        public Boolean RegisterUser(UserDescriptor newUser)
        {
            if (!ContainsUser(newUser))
            {
                m_Users.Add(newUser);
                return true;
            }
            else
                return false;
        }

        public Boolean ContainsUser(UserDescriptor user)
        {
            return m_Users.Contains(user);
        }

        public Boolean AuthValidation(UserDescriptor user)
        {
            int idx = m_Users.IndexOf(user);
            if (idx < 0) return false;
            else return m_Users[idx].AuthValidation(user);
        }

        public void RemoveClientFromChannel(Int32 channelId, UserDescriptor user)
        {
            m_ClientsInChannels[channelId].Remove(user);
        }

        public void AddClientToChannel(Int32 channelId, UserDescriptor user, Socket userSocket)
        {
            m_ClientsInChannels[channelId].Add(user, userSocket);
        }

        public void ReplaceClientToAnotherChannel(Int32 oldChannelId, Int32 newChannelId, UserDescriptor user, Socket userSocket)
        {
            m_ClientsInChannels[oldChannelId].Remove(user);
            m_ClientsInChannels[newChannelId].Add(user, userSocket);
        }

        public void AddMessageToChannel(Int32 channelId, MessageDescriptor msg)
        {
            m_Channels[channelId].AddMessage(msg);
        }


        public DataBase(Int32 maxChannelsCount)
        {
            m_MaxChannelsCount = maxChannelsCount;

            for (int i = 0; i < maxChannelsCount; ++i)
            {
                m_Channels.Add(new Channel());
                m_ClientsInChannels.Add(new Dictionary<UserDescriptor, Socket>());
            }
        }




    }
}
