using System;
//Program loads scriptures from a file and choose a random scripture from the list
class Program
{
    static void Main(string[] args)
    {
        
        List<Scripture> scriptures = new List<Scripture>();

        scriptures = LoadFromFile("scriptures.txt");

        Scripture scripture = GetRamdomScripture(scriptures);

        string userInput = "";
        while (userInput != "quit")
        {

            Console.WriteLine(scripture.GetDisplayText());
        
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if(userInput != "quit"){
                scripture.HideRandomWords(3);
                
                // This will clear the console
                Console.Clear();
            }

            if(scripture.IsCompletelyHidden())
            {
                userInput = "quit";
                Console.WriteLine(scripture.GetDisplayText());
        
                Console.WriteLine(" ");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            }
        }
    }

    static List<Scripture> LoadFromFile(string file)
    {
        
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = System.IO.File.ReadAllLines(file);
      
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            
            
            string text = parts[0];
            string book = parts[1];
            int chapter = int.Parse(parts[2]);
            int verse = int.Parse(parts[3]);
            int endVerse = -1;
            if(parts.Length == 5){
                endVerse = int.Parse(parts[4]);
            }
            
            Reference reference = new Reference(book, chapter, verse, endVerse);
            Scripture scripture = new Scripture(reference, text);
            scriptures.Add(scripture);
        }

        return scriptures;
    }

    static Scripture GetRamdomScripture(List<Scripture> scriptures){

        var rnd = new Random();
        Scripture scripture = scriptures[rnd.Next(0, scriptures.Count)];
        return scripture;
    }

}   