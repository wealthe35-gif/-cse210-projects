using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random random = new Random();

        string[] prompts =
        {
            "What was the best part of your day?",
            "Who made you smile today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "What would you do differently today?",
            "What made you laugh today?",
            "What is one thing you are looking forward to?"
        };
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to your Personal Journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("\nChoose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }
            if (choice == 1)
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine() ?? "";
                string date = DateTime.Now.ToShortDateString();
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
                Console.WriteLine("Entry saved!");
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(filename))
                {
                    journal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully!");
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(filename))
                {
                    journal.LoadFromFile(filename);
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using your journal!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}