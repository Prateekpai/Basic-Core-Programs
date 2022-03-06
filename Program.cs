using System;
using System.Collections.Generic;
using System.Text;

namespace SwapNumbers
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int a, b, c;
            Console.WriteLine("Enter first Number : ");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number :");
            b =Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swaping: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}