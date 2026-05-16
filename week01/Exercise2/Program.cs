using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade percentage? ");
            string userInput = Console.ReadLine();
            int percent = int.Parse(userInput);

            string letter = "";
            string sign = "";

            if (percent >= 90)
            {
                letter = "A";
            }
            else if (percent >= 80)
            {
                letter = "B";
            }
            else if (percent >= 70)
            {
                letter = "C";
            }
            else if (percent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            if (letter == "A" && sign == "+")
            {
                sign = "";
            }

            if (letter == "F")
            {
                sign = "";
            }

            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            if (percent >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Keep trying for next time.");
            }
        }
    }
}