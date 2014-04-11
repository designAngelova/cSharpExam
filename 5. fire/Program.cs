using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Fire
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int halfN = n / 2;
            char dies = '#';
            char dot = '.';
            char line = '-';
            char slashRight = '\\';
            char slahLeft = '/';

            //fire
            for (int i = 0; i < halfN; i++)
            {
               Console.Write(new string (dot, halfN-(i+1)));
               Console.Write(dies);
               Console.Write(new string(dot, i*2));
               Console.Write(dies);
               Console.WriteLine(new string(dot, halfN - (i + 1)));
              
 
            }
            for (int i = 0; i < n/4; i++)
            {
               Console.Write(new string (dot, i));
               Console.Write(dies);
               Console.Write(new string(dot, n-((i*2)+2)));
               Console.Write(dies);
               Console.WriteLine(new string(dot, i));
               

            }
            Console.WriteLine(new string(line, n));

            for (int i = 0; i < halfN;  i++)
            {

                Console.Write(new string (dot, i));
                Console.Write(new string(slashRight, halfN-i));
                Console.Write(new string(slahLeft, halfN - i));
                Console.WriteLine(new string(dot, i));
                 
                
            }
        }
    }

