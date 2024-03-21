public class ListingActivity :Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base()
    {
         _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;

        _prompts = new List<string>
        {
           " Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {GetRamdomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine(" ");
        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"You listed {_count} items!");
        

        DisplayEndingMessage();
    }


    public string GetRamdomPrompt()
    {
        Random r = new Random( );
        int index = r.Next(_prompts.Count );
        string randomPrompt = _prompts[ index ];
        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
       
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            userList.Add(userAnswer);
        }
        
        return userList;
    }
}
