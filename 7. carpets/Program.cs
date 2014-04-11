using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class carpets
    {
        static void Main()
        {
            int n =6;// int.Parse(Console.ReadLine());
            int halfN = n / 2;
            char dot = '.';
            char leftSlash = '\\';
            char rightSlash = '/';
            char empty = ' ';

            for (int i = 0; i < halfN; i++)
            {
                Console.Write(new string(dot,  halfN-(i +1)));
                Console.Write(rightSlash);
                Console.WriteLine(new string(empty, i));
              
                //Console.Write(leftSlash);
                //Console.WriteLine(new string(dot, halfN - (i + 1)));
            }

            //for (int i = 0; i < halfN; i++)
            //{
               
            //   Console.Write(leftSlash);
            //   Console.Write(new string(empty, i * 2));
            //   Console.Write(rightSlash);
            //   Console.Write(new string(dot, i));
            //    //Console.Write(new string(empty, i * 2));

            //    //Console.Write(leftSlash);
            //    //Console.WriteLine(new string(dot, halfN - (i + 1)));
            //}

        }
    }

