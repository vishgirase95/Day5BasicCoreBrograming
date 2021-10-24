using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {

     public static void HarmonicSeries()
        {
            double s = 0;

            float Nth_number =Convert.ToInt32( Console.ReadLine());
            for(double i=1; i<=Nth_number; i++)
            {
                s = s+1 / i;
                Console.WriteLine(s);
            }
        }
    }
}
