using System;

namespace ConsoleApp1
{

   
    class Program
    {

          

         static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1 to campare:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2 to campare:");

            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number3 to campare:");

            int number3 = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[] { number1, number2, number3 };

            Array.Sort(Numbers);

            Console.WriteLine($"{Numbers[Numbers.Length-1]} is the Largest number out of all");
        }
    }
    
}
