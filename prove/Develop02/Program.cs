using System;

class Program
{
    static void Main(string[] args)
    {   
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts._prompts.Add("What are you grateful for, today?");
        prompts._prompts.Add("What is something fun I did today?");

        Journal journal = new Journal();

        int answer = -1;

        while (answer != 5)
        {
            DisplayMenu();
            Console.Write("What you would like to do? ");
            answer = int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userEntry = Console.ReadLine();
                DateTime currentDateTime = DateTime.Now;
                Entry entry = new Entry();

                // Exceeding Requirements: 
                // Save other information in the journal entry (Quote and Music)

                Console.WriteLine("Write a quote for today:");
                string quote = Console.ReadLine();

                Console.WriteLine("Write a music for today:");
                string music = Console.ReadLine();
                
                entry._promptText = prompt;
                entry._date = currentDateTime.ToShortDateString();
                entry._entryText = userEntry;
                
                entry._quote = quote;
                entry._music = music;
                
                journal.AddEntry(entry);
            }
            else if(answer == 2)
            {
                journal.DisplayAll();
            }
            else if(answer == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if(answer == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        }
    }

    static void DisplayMenu(){

        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

    }

}