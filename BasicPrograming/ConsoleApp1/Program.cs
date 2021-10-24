using System;

namespace ConsoleApp1
{

   
    class Program
    {

          

         static void Main(string[] args)
        {
            Console.WriteLine("Enter the A :");
            int a= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the b :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After Swaping , {a} is A and {b} is B");


        }
    }
}
