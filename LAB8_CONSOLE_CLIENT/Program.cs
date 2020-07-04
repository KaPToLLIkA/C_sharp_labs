using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = LAB8_COM_OBJECT;

namespace LAB8_CONSOLE_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            C.Math client = new C.Math();

            while (true)
            {
                Console.WriteLine("1 findArithmeticMeanInIntVector()\n" +
                    "2 findGeometricMeanInIntVector()\n" +
                    "3 findSummOfPositiveValsInIntVector()\n" +
                    "0 EXIT\n\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Result: " + client.findArithmeticMeanInIntVector(getVectorFromConsole()));
                        break;
                    case "2":
                        Console.WriteLine("Result: " + client.findGeometricMeanInIntVector(getVectorFromConsole()));
                        break;
                    case "3":
                        Console.WriteLine("Result: " + client.findSummOfPositiveValsInIntVector(getVectorFromConsole()));
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            }
        }

        static int getInt()
        {
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

        static int[] getVectorFromConsole()
        {
            Console.Write("Print X: ");
            int x = getInt();

            int[] m = new int[x];

            for (int i = 0; i < x; ++i)
            {
                
                Console.Write(i + ": ");

                m[i] = getInt();
                
            }
            return m;

        }
    }
}
