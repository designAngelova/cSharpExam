using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TripleRotationDigits
{
    static void Main()
    {
        //input

        int input = int.Parse(Console.ReadLine());
        string tmpNumber;
        
            
       
        for (int counter = 0; counter < 3; counter++)
			
        {
            if (input > 9)
            {
                int lastDigit = input % 10;
                input /= 10;

                if (lastDigit == 0)
                {
                    tmpNumber = Convert.ToString(input);
                }
                else
                {
                    tmpNumber = Convert.ToString(lastDigit) + Convert.ToString(input);
                }

                input = int.Parse(tmpNumber);
       
			}


        }
        Console.WriteLine(input);
    }
}

