using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LAB1
{
    class MyMath
    {
        public static void FindFibN(BigInteger x0, BigInteger x1, BigInteger targetX)
        {
            BigInteger x2 = x0 + x1;
            Console.WriteLine(x0 + "\n" + x1);
            do
            {
                x0 = x1;
                x1 = x2;
                Console.WriteLine(x2);
                x2 = x0 + x1;
            } while (x2 <= targetX);

        }

        public static BigInteger Fact(BigInteger n)
        {
            BigInteger res = n;
            while (--n >= 1)
                res *= n;
            return res;
        }

        public static void EratosfenFilter(BigInteger maxn)
        {
            if (maxn <= 1) return;

            Boolean insert;
            List<BigInteger> values = new List<BigInteger> { 2 };

            for (BigInteger i = 3; i <= maxn; i++)
            {
                insert = true;
                foreach(BigInteger element in values)
                {
                    
                    if (i % element == 0) insert = false;
                }
                if (insert) values.Add(i);
            }

            foreach (BigInteger element in values)
            {
                Console.WriteLine(element);
            }

        }

        public static void TestCase1()
        {
            Console.WriteLine((new MyMath()).GetType().ToString() + ":FindFibN" + ":TEST1");
            FindFibN(0, 1, 50);
            Console.WriteLine((new MyMath()).GetType().ToString() + ":FindFibN" + ":TEST2");
            FindFibN(1, 1, 13);


            Console.WriteLine((new MyMath()).GetType().ToString() + ":Fact" + ":TEST3");
            Console.WriteLine(Fact(5));
            Console.WriteLine((new MyMath()).GetType().ToString() + ":Fact" + ":TEST4");
            Console.WriteLine(Fact(100));

            Console.WriteLine((new MyMath()).GetType().ToString() + ":EratosfenFilter" + ":TEST5");
            EratosfenFilter(30);
            Console.WriteLine((new MyMath()).GetType().ToString() + ":EratosfenFilter" + ":TEST6");
            EratosfenFilter(100);
        }
    }
}
