using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LAB4_base
{
    [Serializable]
    public class InputData
    {
        public int[,] matrix;
    }

    [Serializable]
    public class OutputData
    {
        public int[,] matrix;
        public int min = Int32.MaxValue, mx = 0, my = 0;
    }


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
    }
}
