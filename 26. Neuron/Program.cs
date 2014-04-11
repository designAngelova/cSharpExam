using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Neuron
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isInside = false;
            bool isonBound = false;
            bool beInside = false;

            while (input != "-1")
            {
               uint inputNum = uint.Parse(Console.ReadLine());
               char[] currentNum = Convert.ToString(inputNum, 2).PadLeft(32,'0').ToCharArray();
               // test: Console.WriteLine(new string(currentNum));


               for (int i = 0; i < currentNum.Length; i++)
               {
                   if (currentNum[i] == '1')
                   {
                       isonBound = true;
                       currentNum[i] == '0';
                       

                   }
                   else
                   {
                       if (!beInside && isonBound)
                       {
                           beInside = true;

                       }
                       if (isInside)
                       {
                           currentNum[i] == '0';
                       }
                   }
               }
            }
        }
    }

