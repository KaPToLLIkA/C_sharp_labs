using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class YearPrinter
    {
        public static void Print(UInt64 start, UInt64 end)
        {
            for(; start <= end; start++)
                if (start % 4 == 0) Console.WriteLine(start + ": Leap Year");
                else Console.WriteLine(start + ": Year");
        }

        public static void TestCase1()
        {
            Console.WriteLine((new YearPrinter()).GetType().ToString() + ":TEST1");
            Print(1980, 2000);
            Console.WriteLine((new YearPrinter()).GetType().ToString() + ":TEST2");
            Print(1999, 2000);

        }
    }
}
