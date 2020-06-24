using System;

namespace LAB2_3_Base.models
{
    [Serializable]
    public class MessageDescriptor
    {
        private DateTime m_DateTime;
        private string m_User;
        private string m_Text;

        public DateTime DateTime
        {
            get { return m_DateTime; }
            set { m_DateTime = value; }
        }

        public string User
        {
            get { return m_User; }
        }

        public string Text
        {
            get { return m_Text; }
        }


       

        public static MessageDescriptor NewMessageNow(UserDescriptor user, string text)
        {
            return new MessageDescriptor(DateTime.Now, user.Name, text);
        }

        public static MessageDescriptor NewMessage(DateTime dateTime, UserDescriptor user, string text)
        {
            return new MessageDescriptor(dateTime, user.Name, text);
        }

        public static MessageDescriptor NewMessageNoTime(UserDescriptor user, string text)
        {
            return new MessageDescriptor(user.Name, text);
        }

        private MessageDescriptor(string user, string text)
        {
           
            m_User = user;
            m_Text = text;
        }
        private MessageDescriptor(DateTime dateTime, string user, string text)
        {
            m_DateTime = dateTime;
            m_User = user;
            m_Text = text;
        }


    }
}
