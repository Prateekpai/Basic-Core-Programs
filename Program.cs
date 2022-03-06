using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd
{
    public class Program
    {
        public static void Main(string[] args)
        {


            int a;

            Console.WriteLine("Enter a Number: ");

            a = Convert.ToInt32(Console.ReadLine());
            {

                if (a % 2 == 0)
                {
                    Console.WriteLine("Entered Number is Even");
                }
                else
                {
                    Console.WriteLine("Enter Number is Odd");
                }
            }
        }
    }
}
