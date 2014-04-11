using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class QuadronacciRectangle
{
    static void Main()
        {
            BigInteger q1 = int.Parse(Console.ReadLine());
            BigInteger q2 = int.Parse(Console.ReadLine());
            BigInteger q3 = int.Parse(Console.ReadLine());
            BigInteger q4 = int.Parse(Console.ReadLine());
            byte r = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            BigInteger result = 0;
            bool isValidR = ((r >= 1) && (r <= 20));
            bool isValidC = ((c >= 4) && (c <= 20));
            if (c == 4)
            {
                Console.Write(q1 + " " + q2 + " " + q3 + " " + q4);
            }
            else
            { 
                Console.Write(q1 + " " + q2 + " " + q3 + " " + q4+ " ");
            }

            if (isValidR && isValidC)
            {
                for (int row = 0; row <= r; row++)
                {
                    for (int col = 0; col < c; col++)
                    {

                        //for (int i = 0; i <= r * c; i++)
                        //{
                        BigInteger nextQ = q1 + q2 + q3 + q4;
                        q1 = q2;
                        q2 = q3;
                        q3 = q4;
                        q4 = nextQ;
                        result = nextQ;
                        Console.Write(" " + result + " ");
                    }

                    Console.WriteLine();
                }
            }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }
        }

                    

