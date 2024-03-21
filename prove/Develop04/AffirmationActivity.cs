public class AffirmationActivity : Activity
{
    private List<string> _affirmations;

     public AffirmationActivity () : base()
    {
        _name = "Affirmation";
        _description = "This activity will help you to create a positive mindset, reduce stress, and improve problem-solving performance under pressure.";
        _duration = 50;

        // Set other values here that are unique to the Reflecting Activity

        _affirmations = new List<string>
        {
            "I am the best at being me.",
            "I am confident in my abilities and can achieve my goals.",
            "I am strong.",
            "I am strong and can overcome every challenge in my life.",
            "I deserve to have joy and fulfillment.",
            "My life is a gift.",
            "It is OK to not be OK.",
            "I am proud of myself for getting this far.",
            "I am allowed to say no to others and yes to myself.",
            "I believe in my ability to get through tough times.",
            "I am blessed, loved, and supported.",
        };        
    }

     public void Run()
    {
        DisplayStartingMessage();

        DisplayAffirmation();

        DisplayEndingMessage();

    }

    public string GetRamdomAffirmation()
    {
        Random r = new Random( );
        int index = r.Next(_affirmations.Count );
        string randomAffirmation = _affirmations[ index ];
        return randomAffirmation;
    }

    public void DisplayAffirmation()
    {
        Console.WriteLine("Read aloud the following affirmations: ");

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
       
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRamdomAffirmation()} ");
            ShowSpinner(5);
            Console.WriteLine(" ");
        }
    
    }
}