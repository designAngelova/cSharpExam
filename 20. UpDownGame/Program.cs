using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UpDownGame
{
    static void Main()
        {
            Console.WriteLine("Try to guess the number");
            Random generateNumber = new Random();
            int endGeneretedNum = generateNumber.Next(1,101);
            int number=0;
            while (endGeneretedNum != number)
            {
                Console.Write("Enter a number");
                number = int.Parse(Console.ReadLine());
                if (endGeneretedNum > number)
                {
                    Console.WriteLine("up");
                }
                else if (endGeneretedNum < number)
                {
                    Console.WriteLine("down");
                }
                else
                    Console.WriteLine("you win");
             }

        }
}

