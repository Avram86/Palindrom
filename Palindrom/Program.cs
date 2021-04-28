using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string text = Console.ReadLine();
            Console.WriteLine($"The word {text} is a palindrome: {IsPalindrome(text)}");
        }

        private static bool IsPalindrome(string text)
        {
            text = text.ToLower();
            bool isPalindrom = false;

            for(int i = 0; i < text.Length/2; i++)
            {
                if (text[i].Equals(text[text.Length - 1 - i] ))
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }

            return isPalindrom;
        }
    }
}
