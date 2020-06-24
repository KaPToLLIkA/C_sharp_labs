using LAB2_3_Base.models;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace LAB2_3_Base.controllers
{

    public class SocketIO
    {
        public static string Serialize<T>(T msg)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();

            try
            {
                bf.Serialize(stream, msg);
                stream.Position = 0;
                return Encoding.Default.GetString(stream.ToArray());
            }
            finally
            {
                stream.Close();
            }
        }


        public static T Diserialize<T>(string str)
        {
            BinaryFormatter bf = new BinaryFormatter();
            byte[] b = Encoding.Default.GetBytes(str);
            MemoryStream stream = new MemoryStream(b);

            try
            {
                return (T)bf.Deserialize(stream);
            }
            finally
            {
                stream.Close();
            }
        }

        public static string ReceiveAll(Socket socket)
        {
            if (!IsSocketStillConnected(socket)) return CmdPrefix.no_CommandPrefix;
            
            string tmpstr = String.Empty;
            byte[] buffer = new byte[1024];
            Int32 read = 0;
     
            
            while(true)
            {
                try
                {
                    read = socket.Receive(buffer);
                } catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }
                tmpstr += Encoding.UTF8.GetString(buffer, 0, read);

                if (tmpstr.EndsWith(CmdPrefix.endMessageSeq)) break;
            }
            if (tmpstr.Length > CmdPrefix.endMessageSeq.Length)
                tmpstr = tmpstr.Remove(tmpstr.Length - CmdPrefix.endMessageSeq.Length);

            if (tmpstr.Length < CmdPrefix.commandPrefixSize) tmpstr = CmdPrefix.no_CommandPrefix;

            return tmpstr;
        }

        

        public static void SendAll(Socket socket, string msg)
        {
            if (!IsSocketStillConnected(socket)) return;

            msg += CmdPrefix.endMessageSeq;
            byte[] msgb = Encoding.UTF8.GetBytes(msg);
            
            try
            {
                socket.Send(msgb, msgb.Length, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static bool IsSocketStillConnected(Socket socket)
        {
            bool connected = true;
            bool blockingState = socket.Blocking;
            try
            {
                byte[] tmp = new byte[1];
                socket.Blocking = false;
                socket.Send(tmp, 0, 0);
            }
            catch (SocketException e)
            {
                
                connected = false;
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                socket.Blocking = blockingState;
            }
            return connected;
        }
    }
}
