using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class UkFlag
    {
        static void Main()
        {
            int n =  int.Parse(Console.ReadLine());
            char star ='*';
            char slashRight ='/';
            char slashLeft = '\\';
            char dash = '-';
            char middleDot = '.';
            char beginDot = '.';
            char line = '|';

       
        for (int row = 0; row < n/2; row++)
			{
			 
			 Console.Write(new string(beginDot, row));
             Console.Write(slashLeft);
             Console.Write(new string(middleDot, (n / 2) - row-1));
             Console.Write(line);
             Console.Write(new string(middleDot, (n / 2) - row - 1));
             Console.Write(slashRight);
             Console.WriteLine(new string(beginDot, row));
			
			}
            Console.Write(new string(dash, n/2));
            Console.Write(star);
            Console.WriteLine(new string(dash, n / 2));
            for (int row = (n/2); row <= n; row++)
            {

                Console.Write(new string(beginDot, row-1));
                Console.Write(slashRight);
                Console.Write(new string(middleDot, (n / 2) - row - 1));
                Console.Write(line);
                Console.Write(slashRight);
                Console.Write(new string(middleDot, (n / 2) - row - 1));
                Console.Write(slashLeft);
                Console.WriteLine(new string(beginDot, row));

            }
        }
    }

