using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Goiko
    {
        static void Main()
        {
            int height =  int.Parse(Console.ReadLine());
            char dot = '.';
            char dash = '-';
            char slashRight = '/';
            char slashLeft = '\\';
            int counter = 1;
            int rows = 1;
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string(dot, height - i-1));
                Console.Write(slashRight);

                if (i == counter)
                {
                    rows++;

                    counter += rows;
                    Console.Write(new string(dash, i * 2));
                }
                else
                {
                    Console.Write(new string(dot, i * 2));
                }
                Console.Write(slashLeft);
                Console.WriteLine(new string(dot, height - i-1));
                
            }
           
        }
    }

