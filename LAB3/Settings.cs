using System;
using System.Net;

namespace LAB3
{
    class ClientSettings
    {
        public static Int32 maxChannelsCount;
        public static Int32 defaultChannelId;
        public static IPAddress hostIp;
        public static Int32 port;
        public static IPEndPoint ipEndPoint;
        


        public static void InitSettings()
        {
            byte[] addr = { 192, 168, 1, 48 };

            maxChannelsCount = 3;
            defaultChannelId = 0;
            hostIp = new IPAddress(addr);
            port = 25566;
            ipEndPoint = new IPEndPoint(hostIp, port);
           

        }
    }
}
