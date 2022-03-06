using System;


namespace VowelOrConsonant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Char alp;
            Console.WriteLine("Enter a Alphabet");
            alp = Convert.ToChar(Console.ReadLine());

            {
                if (alp == 'a' || alp == 'e' || alp == 'i' || alp == 'o' || alp == 'u' || alp == 'A' || alp == 'E' || alp == 'I' || alp == 'O' || alp == 'U')
                {
                    Console.WriteLine("The {0} Alphabet is Vowel:", alp);
                }

                else
                {
                    Console.WriteLine("The {0} Alphabet is Consonant:", alp);
                }
            }
        }
    }
}
