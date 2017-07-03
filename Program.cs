using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word to be translated: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' } ;
            char[] inputArray = input.ToArray();
            int length = inputArray.Length;
            char c = input[0];
            if (vowels.Contains(c))
            {
                Console.WriteLine(input + "way.");
            }
            else if(!vowels.Contains(c))
            {
                string sub = input.Substring(1, length);
                Console.WriteLine(sub + c + "ay");
                //sub plus index 0 plus ay
            }
            else
            {
                Console.WriteLine("Please enter a valid word.");
            }
            
        }
    }
}
