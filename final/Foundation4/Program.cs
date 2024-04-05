using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("05 Nov 2022", 40, 6.0);
        Swimming swimming = new Swimming("13 Nov 2022", 30, 50);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummaty());
        }
    }
}