using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;
        int sails = (2 * height) / 3;
        int rest = height / 3;
        int dotCount = n;
        int starCount = 1;
        int dotCountDown = 1;

        for (int i = 0; i < 2; i++)
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.WriteLine(new string('.', dotCount));
            dotCount--;
            starCount += 2;
        }
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', dotCount) + '*' + new string('.', dotCountDown) + '*' +
                new string('.', dotCountDown) + '*' + new string('.', dotCount));
            Console.WriteLine();
            dotCount--;
            dotCountDown++;
        }
        Console.Write(new string('*', width));
        Console.WriteLine();
        dotCountDown = 1;
        dotCount = n - 2;
        int loopLenght = height - (n + 1);
        for (int i = 0; i < loopLenght - 1; i++)
        {
            Console.Write(new string('.', dotCountDown) + '*' + new string('.', dotCount) + '*'
                + new string('.', dotCount) + '*' + new string('.', dotCountDown));
            Console.WriteLine();
            dotCount--;
            dotCountDown++;
        }
         int lastWidth = (width - n) / 2;
                Console.WriteLine(new string('.', lastWidth) + new string('*', n) + new string('.', lastWidth));
            }
    }

