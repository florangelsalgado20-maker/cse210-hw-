using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prompt the user for input
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            // 2. Add a blank line for clean formatting
            Console.WriteLine();

            // 3. Output the result using string interpolation ($"")
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        }
    }
}