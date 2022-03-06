using System;
using System.Collections.Generic;
using System.Text;
namespace PowerOfTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            int m = 2;

            Console.WriteLine("Enter A Number");
            n = Convert.ToInt32(Console.ReadLine());

            {
                if (n <= 32)


                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("The Power of 2 when N is {0} = {1} :", i, Math.Pow(m, i));
                    }

                }

                else

                {
                    Console.WriteLine("Enter a number Below 32: ");
                }
            }

        }
    }
}

