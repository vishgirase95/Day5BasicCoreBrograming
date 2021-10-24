using System;

namespace ConsoleApp1
{


   
    class Program
    {

            static int CorrectYear = 999;

        public static void CheckYear() {
            int InputYear = Convert.ToInt32(Console.ReadLine());

            if (InputYear < 999)
            {
                Console.WriteLine("Please Enter Year in YYYY form.");

            }
            else
            {
                CorrectYear = InputYear;
            }
          
        }


        public static void CheckLeapYear()
        {

            if (CorrectYear > 999) 

            if (CorrectYear % 4 == 0)
            {
                if (CorrectYear % 100 == 0)
                {
                    if (CorrectYear % 400 == 0)
                    {
                        Console.WriteLine($"{CorrectYear} is leap Year");

                    }
                    else
                    {
                        Console.WriteLine($"{CorrectYear} is not leap Year");

                    }
                }
                else
                {
                    Console.WriteLine($"{CorrectYear} is leap Year");


                }
            }
            else
            {
                Console.WriteLine($"{CorrectYear} is not leap Year");
            }
        }



         static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Year to check if its Leap Year :");
           
            CheckYear();

            CheckLeapYear();




        }
    }
}
