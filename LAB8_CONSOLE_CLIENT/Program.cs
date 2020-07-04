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
                Console.WriteLine("1 findMiddleOfNonPositiveValsInIntMatrix()\n" +
                    "2 findMinMiddleOfColumnsInIntMatrix()\n" +
                    "3 findMaxMiddleOfRowsInIntMatrix()\n" +
                    "0 EXIT\n\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Result: " + client.findMiddleOfNonPositiveValsInIntMatrix(getMatrixFromConsole()));
                        break;
                    case "2":
                        Console.WriteLine("Result: " + client.findMinMiddleOfColumnsInIntMatrix(getMatrixFromConsole()));
                        break;
                    case "3":
                        Console.WriteLine("Result: " + client.findMaxMiddleOfRowsInIntMatrix(getMatrixFromConsole()));
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

        static int[,] getMatrixFromConsole()
        {
            Console.Write("Print X: ");
            int x = getInt();

            Console.Write("Print Y: ");
            int y = getInt();

            int[,] m = new int[y, x];

            for (int r = 0; r < y; ++r)
            {
                for (int c = 0; c < x; ++c)
                {
                    Console.Write(r + ":" + c + "  ");

                    m[r, c] = getInt();
                }
            }
            return m;

        }
    }
}
