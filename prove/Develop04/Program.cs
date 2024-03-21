using System;
using System.Runtime.InteropServices;

//Exceeding Requirements: Adding another kind of activity. - I added the Affirmation Activity
class Program
{
    static void Main(string[] args)
    {
        int answer = -1;

        while (answer != 5)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start affirmation activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(answer == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if(answer == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if(answer == 4)
            {
                AffirmationActivity affirmationActivity = new AffirmationActivity();
                affirmationActivity.Run();
            }
        }
    }
}