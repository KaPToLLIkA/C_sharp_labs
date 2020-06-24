using System.Net;
using System.Net.Sockets;

namespace LAB3
{
    class Data
    {
        public static bool connectedToServer = false;
        public static bool authorizedOnServer = false;
        public static bool parseIPsuccess = false;
        public static int currentChannel = ClientSettings.defaultChannelId;
        public static Socket serverSocket;
        public static IPEndPoint ipServer;
        public static string loggedUserName;
        public static bool listenerStarted = false;
    }
}
