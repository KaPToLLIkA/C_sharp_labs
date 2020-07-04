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
            C.StrUtil client = new C.StrUtil();

            while (true)
            {
                Console.WriteLine("1 toUpperCase()\n" +
                    "2 toLowerCase()\n" +
                    "3 toUpperCaseFirstLetterInWords()\n" +
                    "0 EXIT\n\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Print str: ");
                        Console.WriteLine("Result: " + client.toUpperCase(Console.ReadLine()));
                        break;
                    case "2":
                        Console.Write("Print str: ");
                        Console.WriteLine("Result: " + client.toLowerCase(Console.ReadLine()));
                        break;
                    case "3":
                        Console.Write("Print str: ");
                        Console.WriteLine("Result: " + client.toUpperCaseFirstLetterInWords(Console.ReadLine()));
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            }
        }

       
    }
}
