using System;
using System.Globalization;
using System.Threading;

    class MathExpression
    {
        static void Main()
        {              
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;
            const double  a =  128.523123123d;
            
            double divider = (n * n) + (1 / (m * p)) + 1337;
            double divison = (n - a * p);
            double result = (divider / divison) + Math.Sin((int)m % 180);
            Console.WriteLine("{0:f6}", result);
        }
    }

