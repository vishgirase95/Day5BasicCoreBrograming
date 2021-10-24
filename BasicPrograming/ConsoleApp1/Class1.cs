using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {

     

        public static void TwoPower()
        {
            int InputPower =Convert.ToInt32( Console.ReadLine());

            for (int i = 1; i <= InputPower; i++) {

                Console.WriteLine(Math.Pow(2, i));

 
              
            
            }

        }

    }
}
