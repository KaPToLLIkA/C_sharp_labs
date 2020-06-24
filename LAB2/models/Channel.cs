using LAB2_3_Base.models;
using System;
using System.Collections.Generic;

namespace LAB2.models
{
    [Serializable]
    class Channel
    {
        private List<MessageDescriptor> m_Messages = new List<MessageDescriptor>();
        
        public void AddMessage(MessageDescriptor message)
        {
            m_Messages.Add(message);
        } 

        public List<MessageDescriptor> GetNLastMessages(Int32 n)
        {
            if (n >= m_Messages.Count) return m_Messages.GetRange(0, m_Messages.Count);
            else return m_Messages.GetRange(m_Messages.Count - n, n);
        }

        public List<MessageDescriptor> GetAllMessages()
        {
            return m_Messages.GetRange(0, m_Messages.Count);
        }

        public Channel()
        {

        }
    }
}
