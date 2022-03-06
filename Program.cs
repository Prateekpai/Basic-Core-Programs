using System;

namespace BasicCOreProgram
{
    class ProgramLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year:");
            int year =  Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("The Entered Year is a Leap Year");
            }
                    
            else
            {
                Console.WriteLine("The Entered Year is Not a Leap Year");
            }
                


        }
    }
}
