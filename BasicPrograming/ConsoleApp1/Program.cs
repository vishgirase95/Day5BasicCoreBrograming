using System;

namespace ConsoleApp1
{

   
    class Program
    {

          

         static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int a= Convert.ToInt32( Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is Even Number");
            }
            else
            {
                Console.WriteLine($"{a} is Odd Number");

            }

        }
    }
}
