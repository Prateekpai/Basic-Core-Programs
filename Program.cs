using System;
using System.Collections.Generic;
using System.Text;
namespace QuotientAndReminder
{
    public class Program
    {
        public static void Main (string[]args)
        {
            int a,b;

            Console.WriteLine("Enter a Dividend: ");
            a =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Divisor: ");
            b = Convert.ToInt32(Console.ReadLine());

            int Quotient = a / b;
            int reminder = b / a;
            Console.WriteLine( "The Quotient is :{0}",Quotient);
            Console.WriteLine("The Remainder is : {0}",reminder);
        }
    }
}
