using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade percentage: ");
            string userInput = Console.ReadLine();
            int gradePercentage = int.Parse(userInput);

            string letter = "";
            string sign = "";

            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            int lastDigit = gradePercentage % 10;

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

            Console.WriteLine();
            Console.WriteLine($"Your final grade is: {letter}{sign}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Keep working hard for the next time.");
            }
        }
    }
}
