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

            while (!scripture.IsComplete)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.Write("\nPress ENTER to hide more words, or type 'quit' to exit: ");
                
                string input = Console.ReadLine()?.Trim().ToLower();
                if (input == "quit" || input == "exit") break;
                
                scripture.HideRandomWord();
                scripture.HideRandomWord();
            }

            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nMemorization exercise complete. Well done!");
        }
    }
}
