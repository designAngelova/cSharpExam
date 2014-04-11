using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



    class NextDate
    {
        static void Main()
        {
            //input
            byte day = byte.Parse(Console.ReadLine());
            byte month = byte.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
           DateTime inputDate = DateTime.Parse(day + "." + month + "." + year);
           
            Console.WriteLine(inputDate);
            //otput
            Console.WriteLine(inputDate.AddDays(1));
        }
    }

