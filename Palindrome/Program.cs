using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            string sequenceCharacters = Console.ReadLine().ToUpper().Trim();

            if (sequenceCharacters.Length % 2 == 0)
            {
                int count = 0;
                for (int i = 0; i < (sequenceCharacters.Length / 2); i++)
                {
                    if (sequenceCharacters[i] == sequenceCharacters[(sequenceCharacters.Length) - i])
                    {
                        count++;
                    }
                }
                if (count == sequenceCharacters.Length / 2)
                {
                    Console.WriteLine("It's Palindrome!");
                }
                else
                {
                    Console.WriteLine("It's not Palindrome!");
                }
            }


            Console.WriteLine(quantityCharacteres);
            Console.WriteLine(sequenceCharacters);


        }
    }
}
