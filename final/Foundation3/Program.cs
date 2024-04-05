using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("128 N Mill", "Orem", "Utah", "USA");
        Lecture lecture = new Lecture("Discover the Secret to Falling in Love with Work", "A transformative webinar that will change how you think about, interact, and grow on your work.", "04/24/2024", "7 PM", address1, "Jonh Doe", 100);

        Address address2 = new Address("234 S 3456 W", "Sandy", "Utah", "USA");
        Reception reception = new Reception("Mary and John Smith Wedding", "Come celebrate this day with us!", "4/20/2024", "5-8 PM", address2, "mary@gmail.com");

        Address address3 = new Address("123 North Mill", "Provo", "Utah", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Tulip Plant Class", "Learn how to make your garden bloom this spring!!", "4/15/2024", "9 AM", address3, "Sunny");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach(Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine(evt.GetShortDescription());
        }
    }
}