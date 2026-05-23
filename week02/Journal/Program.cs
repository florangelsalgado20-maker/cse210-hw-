using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to file");
            Console.WriteLine("4. Load the journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(prompt, response, date);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved.");
                    break;
                case "4":
                    Console.Write("Filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded.");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
