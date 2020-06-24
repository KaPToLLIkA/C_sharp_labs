using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class ArrayPrinter<T>
    {
        public static void Print(T[] Array)
        {

            Console.Write(Array.ToString() + " { ");
            foreach (T Element in Array)
            {
                Console.Write(Element.GetType().ToString() + "(" + Element + "), ");
            }
            Console.Write("}\n");
        }

        public static void TestCase1()
        {
            string[] arr1 = { "a", "b", "c" };
            int[] arr2 = { 2, 3, 4, 5, 6, 6 };
            Console.WriteLine((new ArrayPrinter<string>()).GetType().ToString() + ":TEST1");
            ArrayPrinter<string>.Print(arr1);
            Console.WriteLine((new ArrayPrinter<int>()).GetType().ToString() + ":TEST2");
            ArrayPrinter<int>.Print(arr2);

        }

    }
}
