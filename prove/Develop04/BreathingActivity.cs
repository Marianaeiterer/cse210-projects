public class BreathingActivity : Activity
{
    
    public BreathingActivity() : base()
    {
         _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(" ");
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine(" ");
        }

        DisplayEndingMessage();
    }
} 