
using LAB4_base;
using Nwc.XmlRpc;
using System;

namespace LAB4_server
{



    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true) {
                int size = 0;
                InputData data = new InputData();
                Console.Write("Print size: ");
                
                while (true)
                {
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }


                if (size == 0) break;
                else data.matrix = new int[size, size];

                Console.WriteLine("Print matrix:");
                for (int y = 0; y < size; ++y) {
                    Console.WriteLine("Line: " + y);
                    for (int x = 0; x < size; ++x)
                    {
                        while (true)
                        {
                            try
                            {
                                data.matrix[y,x] = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Wrong input!");
                            }
                        }
                    }
                }

                for (int y = 0; y < size; ++y)
                {
                    for (int x = 0; x < size; ++x)
                        Console.Write(data.matrix[y,x] + "\t");
                    Console.WriteLine();
                }

                XmlRpcRequest request = new XmlRpcRequest();
                request.Params.Clear();
                request.Params.Add(SocketIO.Serialize(data));
                request.MethodName = "MyProc.remoteMatrixProc";

                XmlRpcResponse response = request.Send("http://127.0.0.1:25566");
                OutputData answer = SocketIO.Diserialize<OutputData>(response.Value as String);

                Console.WriteLine(answer.min);
                for (int y = 0; y < size; ++y)
                {
                    for (int x = 0; x < size; ++x)
                        Console.Write(answer.matrix[y, x] + "\t");
                    Console.WriteLine();
                }

            }


            
        }
    }
}
