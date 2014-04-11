using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        int[] numArr = new int[n];  
        string result = "";
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            int number = int.Parse(Console.ReadLine());
            result = Convert.ToString(number, 2);

            for (int bit = 0; bit < result.Length; bit++)
            {
                if (result[bit] == '0' && b == 0)
                {
                    sum++;
                }
                else if (result[bit] == '1' && b == 1)
                {
                    sum++; 
                }
            }

            numArr[i] = sum;

        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numArr[i]);
        }
        
    }

    
    }
