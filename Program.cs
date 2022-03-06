using System;
using System.Text;
using System.Collections.Generic;
namespace HarmonicNumberProgram
{
    public class Program
    {
        public static void Main()
        {
            int i, n;
            {
                Console.Write("Input the number of terms : ");
            }

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);

            }
        }
    }
}

