using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {


       public static int number1 = Convert.ToInt32(Console.ReadLine());
       public static  int number2 = Convert.ToInt32(Console.ReadLine());

        public static void Remainder()
        {

            int reminder = number1 % number2;
            Console.WriteLine($"{reminder} is the Remainder");



        }

        public static void Quotietent()
        {


            int quotient = number1 /number2;
            Console.WriteLine($"{quotient} is the Quotietent");


        }
    }
}
