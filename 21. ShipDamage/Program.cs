using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Problem_ShipDamage
{
    class ShipDamage
    {
        static void Main()
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            int newCy1 = H + (H - Cy1);
            int newCy2 = H + (H - Cy2);
            int newCy3 = H + (H - Cy3);
            double damage = 0;

            //Corners hit
            if ((Cx1 == Sx1 && newCy1 == Sy1) || (Cx1 == Sx2 && newCy1 == Sy2) || (Cx1 == Sx1 && newCy1 == Sy2) || (Cx1 == Sx2 && newCy1 == Sy1))
            {
                damage = damage + 0.25;
            }
            if ((Cx2 == Sx1 && newCy2 == Sy1) || (Cx2 == Sx2 && newCy2 == Sy2) || (Cx2 == Sx1 && newCy2 == Sy2) || (Cx2 == Sx2 && newCy2 == Sy1))
            {
                damage = damage + 0.25;
            }
            if ((Cx3 == Sx1 && newCy3 == Sy1) || (Cx3 == Sx2 && newCy3 == Sy2) || (Cx3 == Sx1 && newCy3 == Sy2) || (Cx3 == Sx2 && newCy3 == Sy1))
            {
                damage = damage + 0.25;
            }

            //Sides hit
            if ((Cx1 == Sx1 && newCy1 < Math.Max(Sy1, Sy2) && newCy1 > Math.Min(Sy1, Sy2)) ||
                (Cx1 == Sx2 && newCy1 < Math.Max(Sy1, Sy2) && newCy1 > Math.Min(Sy1, Sy2)) ||
                (newCy1 == Sy1 && Cx1 < Math.Max(Sx1, Sx2) && Cx1 > Math.Min(Sx1, Sx2)) ||
                (newCy1 == Sy2 && Cx1 < Math.Max(Sx1, Sx2) && Cx1 > Math.Min(Sx1, Sx2)))
            {
                damage = damage + 0.5;
            }
            if ((Cx2 == Sx1 && newCy2 < Math.Max(Sy1, Sy2) && newCy2 > Math.Min(Sy1, Sy2)) ||
                (Cx2 == Sx2 && newCy2 < Math.Max(Sy1, Sy2) && newCy2 > Math.Min(Sy1, Sy2)) ||
                (newCy2 == Sy1 && Cx2 < Math.Max(Sx1, Sx2) && Cx2 > Math.Min(Sx1, Sx2)) ||
                (newCy2 == Sy2 && Cx2 < Math.Max(Sx1, Sx2) && Cx2 > Math.Min(Sx1, Sx2)))
            {
                damage = damage + 0.5;
            }
            if ((Cx3 == Sx1 && newCy3 < Math.Max(Sy1, Sy2) && newCy3 > Math.Min(Sy1, Sy2)) ||
                (Cx3 == Sx2 && newCy3 < Math.Max(Sy1, Sy2) && newCy3 > Math.Min(Sy1, Sy2)) ||
                (newCy3 == Sy1 && Cx3 < Math.Max(Sx1, Sx2) && Cx3 > Math.Min(Sx1, Sx2)) ||
                (newCy3 == Sy2 && Cx3 < Math.Max(Sx1, Sx2) && Cx3 > Math.Min(Sx1, Sx2)))
            {
                damage = damage + 0.5;
            }

            //Body hit
            if ((Cx1 < Math.Max(Sx1, Sx2) && Cx1 > Math.Min(Sx1, Sx2) && newCy1 < Math.Max(Sy1, Sy2) && newCy1 > Math.Min(Sy1, Sy2)))
            {
                damage = damage + 1;
            }
            if ((Cx2 < Math.Max(Sx1, Sx2) && Cx2 > Math.Min(Sx1, Sx2) && newCy2 < Math.Max(Sy1, Sy2) && newCy2 > Math.Min(Sy1, Sy2)))
            {
                damage = damage + 1;
            }
            if ((Cx3 < Math.Max(Sx1, Sx2) && Cx3 > Math.Min(Sx1, Sx2) && newCy3 < Math.Max(Sy1, Sy2) && newCy3 > Math.Min(Sy1, Sy2)))
            {
                damage = damage + 1;
            }
            Console.WriteLine("{0:0%}", damage);
        }
    }
}