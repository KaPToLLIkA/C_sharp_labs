
using LAB2.views;
using System;


namespace HelloApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ServerMainThread.Init();
            ServerMainThread.Run();
            Console.ReadKey();
        }
    }
}