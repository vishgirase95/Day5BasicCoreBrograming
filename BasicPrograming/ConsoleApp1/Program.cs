using System;

namespace ConsoleApp1
{

   
    class Program
    {

          

         static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet to check Vowels or consonants:");
            string Alphabet = Console.ReadLine();
            string[] Vowels = new string[5] { "a","e","i","o","u"};
            int yes = 0;

            for (int i = 0; i < Vowels.Length; i++)
            {
                if (Alphabet == Vowels[i])
                {
                    yes++;
                }

                if (yes == 1)
                {
                    Console.WriteLine($"{Alphabet} is the Vowels");
                    break;
                }
                else
                {
                    Console.WriteLine($"{Alphabet} is the consonants");
                    break;


                }
            }
        }
    }
}
