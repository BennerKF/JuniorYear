using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "";
            while (palindrome != "exit")
            {
                Console.WriteLine("PALINDROME CHECKER V1.0");
                Console.WriteLine("Type 'exit' to close program");
                Console.WriteLine("----------------------------");
                Console.Write("Please Type A Word/Sentence: ");
                palindrome = Console.ReadLine();
                Console.WriteLine();

                palindrome = palindrome.Replace(" ", "").Replace(".", "").Replace("'", "").Replace(",", "").Replace(";", "").Replace("!", "").Replace("?", "").Replace("\"", "").Replace(":", "").Replace("(", "").Replace(")", "").Replace("%", "").Replace("-", "").Replace("/", "").Replace("$", "").Replace("#", "").Replace("@", "");
                palindrome = palindrome.ToLower();

                for (int i = 0; i < palindrome.Length; i++)
                {
                    if (palindrome == "exit")
                    {
                        Console.WriteLine("GOODBYE!");
                        break;
                    }
                    
                    else if (palindrome[i] != palindrome[palindrome.Length - 1 - i])
                    {
                        i = palindrome.Length - 1;
                        Console.WriteLine("This is not a palindrome.");
                    }

                    else if (palindrome[i] == palindrome[palindrome.Length - 1 - i])
                    {
                        if (i == palindrome.Length - 1)
                        {
                            Console.WriteLine("This is a palindrome.");
                        }
                    }

                }
                Console.WriteLine();
            }
            
        }
    }
}
