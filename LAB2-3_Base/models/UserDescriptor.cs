using System;


namespace LAB2_3_Base.models
{
    [Serializable]
    public class UserDescriptor
    {
        private string m_Name;
        private string m_Password;

        public string Name
        {
            get { return m_Name; }
        }

        public string Password
        {
            get { return m_Password; }
        }
        public UserDescriptor(string name, string password)
        {
            m_Name = name;
            m_Password = password;
        }

        public UserDescriptor(string name)
        {
            m_Name = name;
            m_Password = string.Empty;
        }

        public bool AuthValidation(UserDescriptor user)
        {
            return user.m_Name == this.m_Name && user.m_Password == this.m_Password;
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            UserDescriptor objAsUserDesc = obj as UserDescriptor;
            if (objAsUserDesc == null) return false;
            else return Equals(objAsUserDesc);
        }


        public bool Equals(UserDescriptor user)
        {
            return this.m_Name == user.m_Name;
        }

        //public static bool operator ==(UserDescriptor a, UserDescriptor b)
        //{
        //    if ( || b == null) return false;
        //    else return (a.m_Name == b.m_Name);
        //}

        //public static bool operator !=(UserDescriptor a, UserDescriptor b)
        //{
        //    return (a.m_Name != b.m_Name);
        //}

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }
}
