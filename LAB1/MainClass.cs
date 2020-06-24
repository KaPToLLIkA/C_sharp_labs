using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayPrinter<string>.TestCase1();
            YearPrinter.TestCase1();
            MyMath.TestCase1();

            Console.ReadKey();
        }
    }
}
