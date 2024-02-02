using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3Shiritori
{

    class Program
    {
        static void Main(string[] args)
        {
            Shiritori myShiritori = new Shiritori();
            Console.WriteLine("Welcome to Shiritori! Enter words to play. Type 'exit' to end the game.");

            while (!myShiritori.game_over)
            {
                Console.Write("Enter a word: ");
                string word = Console.ReadLine();

                if (word.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine(string.Join(", ", myShiritori.Play(word)));
            }
        }
    }
}