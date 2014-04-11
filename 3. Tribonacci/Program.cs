using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class Tribonacci
    {
        static void Main()
        {
            BigInteger t1 = int.Parse(Console.ReadLine());
            BigInteger t2 = int.Parse(Console.ReadLine());
            BigInteger t3 = int.Parse(Console.ReadLine());
            BigInteger n =  int.Parse(Console.ReadLine());
            BigInteger tNext = 0;
            BigInteger result = 0;
            if (n == 1)
            {
                result = t1;
            }
                if (n==2)
                {
                    result = t2;
                }
                if (n == 3)
                {
                    result = t3;
                }
                else
                {
                    for (int i = 3; i < n; i++)
                    {
                        tNext = t1 + t2 + t3;
                        t1 = t2;
                        t2 = t3;
                        t3 = tNext;
                        result = t3;
                    }
                }
            Console.WriteLine(result);
        }
    }

