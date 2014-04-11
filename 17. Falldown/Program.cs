using System;

namespace _05.FallDown
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Input
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());

            // Solution
            for (int i = 0; i < 7; i++)
            {
                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n7 >> bitPosition & 1) == 0 &&
                        (n6 >> bitPosition & 1) == 1)
                    {
                        n7 |= (1 << bitPosition);
                        n6 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n6 >> bitPosition & 1) == 0 &&
                        (n5 >> bitPosition & 1) == 1)
                    {
                        n6 |= (1 << bitPosition);
                        n5 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n5 >> bitPosition & 1) == 0 &&
                        (n4 >> bitPosition & 1) == 1)
                    {
                        n5 |= (1 << bitPosition);
                        n4 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n4 >> bitPosition & 1) == 0 &&
                        (n3 >> bitPosition & 1) == 1)
                    {
                        n4 |= (1 << bitPosition);
                        n3 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n3 >> bitPosition & 1) == 0 &&
                        (n2 >> bitPosition & 1) == 1)
                    {
                        n3 |= (1 << bitPosition);
                        n2 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n2 >> bitPosition & 1) == 0 &&
                        (n1 >> bitPosition & 1) == 1)
                    {
                        n2 |= (1 << bitPosition);
                        n1 ^= (1 << bitPosition);
                    }
                }

                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    if ((n1 >> bitPosition & 1) == 0 &&
                        (n0 >> bitPosition & 1) == 1)
                    {
                        n1 |= (1 << bitPosition);
                        n0 ^= (1 << bitPosition);
                    }
                }
            }

            // Output
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
        }
    }
}