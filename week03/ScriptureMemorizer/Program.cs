/*
 * Scripture Memorizer Program - CSE 210 Week 03
 * 
 * EXCEEDING REQUIREMENTS:
 * 1. Smart word selection - avoids hiding same word twice
 * 2. Hides 2 words per turn for faster progression
 * 3. Accepts both 'quit' and 'exit' commands
 * 4. Clear console for better user experience
 * 5. Progress tracking with GetProgressPercentage()
 */

using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            var scripture = new Scripture(reference, text);

            while (!scripture.AllWordsHidden())  // ✅ Corregido
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nPress ENTER to hide more words, or type 'quit' to exit: ");

                string input = Console.ReadLine()?.Trim().ToLower();
                if (input == "quit" || input == "exit") break;

                scripture.HideRandomWords(2);  // ✅ Corregido
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nMemorization exercise complete. Well done!");
        }
    }
}
