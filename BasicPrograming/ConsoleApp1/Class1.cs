using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {

     public static void PrimeFactor()
        {
            int number =Convert.ToInt32( Console.ReadLine());
            int diviser = 0;

            for (int i = 2; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {

                    diviser++;
                }
            }
                if (diviser == 0)
                {
                    Console.WriteLine($"{number} is a prime");
                }
                else
                {
                    Console.WriteLine($"{number} is not prime");
                    
                }
           

            

        }
    }
}
