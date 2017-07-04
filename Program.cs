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
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a word to be translated: ");
                string input = Console.ReadLine();
                input = input.ToLower();
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                char[] inputArray = input.ToArray();
                int length = inputArray.Length;
                char c = input[0];
                Boolean nonAlpha = true;
                foreach(var letter in input)
                {
                    if (Char.IsDigit(letter) || Char.IsPunctuation(letter) || Char.IsSymbol(letter))
                    {
                        nonAlpha = false;
                        break;
                    }
                }
                if (nonAlpha && vowels.Contains(c))
                {
                    Console.WriteLine($"Translation: {input}way.");
                }
                else if (nonAlpha && !vowels.Contains(c))
                {
                    string sub = input.Substring(1);
                    Console.WriteLine($"Translation: {sub}{c}ay");
                }
                else if (!nonAlpha)
                {
                    Console.WriteLine($"Translation: {input}");
                }

                run = Continue();
            }
        }
            public static Boolean Continue() {
                Boolean run;
                Console.WriteLine("Enter a new word? (y/n): ");
                string answer = Console.ReadLine();

                    if (answer == "y" || answer == "Y")
                    {
                        run = true;
                    }
                    else if (answer == "n" || answer == "N")
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Input not valid. Please try again.");
                        run = Continue();
                    }
            return run;
            }
        }
    }
