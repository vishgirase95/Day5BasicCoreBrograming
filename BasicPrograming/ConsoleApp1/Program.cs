using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentFlip = 1;
            Console.WriteLine("Enter The number of Flip :");
            int flipNumber = Convert.ToInt32(Console.ReadLine());
            int HeadCount = 0;
            int TailCount = 0;

            int i = 0;
            while (i <= flipNumber)
            {
                Random flip = new Random();
                int  RandomNumber= flip.Next(1, 3);


                if (currentFlip == RandomNumber)
                {
                    Console.WriteLine("Head");
                    HeadCount++;
                }
                else
                {
                    Console.WriteLine("Tail");
                    TailCount++;
                }
                i++;
            }

            int PercentageOfHead = (100 * HeadCount) / flipNumber;
            int PercentageOfTail =100- PercentageOfHead;
            Console.WriteLine($"The Percentage of Head count {PercentageOfHead}% and the percentage of tail count is {PercentageOfTail}%");        
        }
    }
}
