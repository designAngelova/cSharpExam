using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
    class AstrologicalDigit
    {
        static void Main()
        {
           string inputNumber = Console.ReadLine();
           BigInteger sum = 0;

           for (int i = 0; i < inputNumber.Length; i++)
           {
               if ((inputNumber[i] != '.' ) && inputNumber[i] != '-')
               {
                   sum += int.Parse(inputNumber[i].ToString());
               }
               if (sum > 9)
               {
                   BigInteger newSum = 0;
                   string sumString = sum.ToString();
                   for (int j = 0; j < sumString.Length; j++)
                   {
                       newSum += int.Parse(sumString[j].ToString());
                       sum = newSum;
                   }
               }
              
           }
           
            
            Console.WriteLine(sum);
        }
    }

