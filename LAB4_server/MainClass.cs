
using LAB4_base;
using Nwc.XmlRpc;
using System;

namespace LAB4_server
{



    class MyProc
    {


        public string remoteMatrixProc(string inarg)
        {
            Console.WriteLine("Invoke \"remoteMatrixProc\"");
            InputData arg = SocketIO.Diserialize<InputData>(inarg);

            OutputData result = new OutputData();
            
            result.matrix = arg.matrix;
            

            int size = Convert.ToInt32(Math.Sqrt(arg.matrix.Length));
            bool mainDiagonal = true;

            for (int y = 0, x = 0; x < size && y < size; ++x, ++y)
                if (result.matrix[y, x] < result.min)
                    result.min = result.matrix[y, x];

            for (int y = 0, x = size - 1; x >= 0 && y < size; --x, ++y)
                if (result.matrix[y, x] < result.min)
                {
                    result.min = result.matrix[y, x];
                    mainDiagonal = false;
                }

            if (mainDiagonal)
            {
                for (int y = 0, x = 0; x < size && y < size; ++x, ++y)
                {
                    result.matrix[y, x] = 0;
                    for (int yy = y + 1; yy < size; ++yy)
                        result.matrix[yy, x] *= result.matrix[yy, x];
                }

            } 
            else
            {
                for (int y = 0, x = size - 1; x >= 0 && y < size; --x, ++y)
                {
                    result.matrix[y, x] = 0;
                    for (int yy = y + 1; yy < size; ++yy)
                        result.matrix[yy, x] *= result.matrix[yy, x];
                }

            }


            return SocketIO.Serialize(result);
        }


    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            XmlRpcServer server = new XmlRpcServer(25566);

            server.Add("MyProc", new MyProc());
            server.Start();
            
        }
    }
}
