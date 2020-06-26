using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            string sequenceCharacters = Console.ReadLine().ToUpper().Trim();
            int quantityCharacters = sequenceCharacters.Length;

            if (quantityCharacters % 2 == 0)
            {
                int count = 0;
                for (int i = 0; i < (quantityCharacters / 2); i++)
                {
                    if (sequenceCharacters[i] == sequenceCharacters[quantityCharacters - (i + 1)])
                    {
                        count++;
                    }
                }
                if (count == quantityCharacters / 2)
                {
                    Console.WriteLine("It's Palindrome!");
                }
                else
                {
                    Console.WriteLine("It's not Palindrome!");
                }
            }
            else
            {
                int count = 0;
                for (int i = 0; i <= ((quantityCharacters - 1) / 2); i++)
                {
                    if (sequenceCharacters[i] == sequenceCharacters[quantityCharacters - (i + 1)])
                    {
                        count++;
                    }
                }
                if (count == ((quantityCharacters - 1) / 2) + 1)
                {
                    Console.WriteLine("It's Palindrome!");
                }
                else
                {
                    Console.WriteLine("It's not Palindrome!");
                }
            }




        }
    }
}
