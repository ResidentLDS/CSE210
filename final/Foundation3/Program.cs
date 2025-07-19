using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> eventList = new List<Event>();
        Lectures lecture_1 = new Lectures("TedTalk", "To talk about doing something you love and enjoy.", "September 21, 2028", "7:00 am", "261 Randall Drive, Folsom, California, USA 95630", "Walt Disney", 75);
        Receptions reception_1 = new Receptions("Bill and Jenny's Wedding", "A celebration of the union between Bill and Jenny.", "July 30, 2026", "6:30 pm", "1250 Main Street, Broomfield, Colorado, USA 80020", "bill&mandy@marriage.org");
        Outdoors outdoor_1 = new Outdoors("4th of July BBQ", "A get together of those who live on the block to get together and enjoy the 4th of July.", "July 4, 2025", "11:15 am", "19535 E Appleby Rd, Queen Creek, Arizona, USA 85142", "Partly Cloudy, 85°F");

        eventList.Add(lecture_1);
        eventList.Add(reception_1);
        eventList.Add(outdoor_1);


        Console.WriteLine("Standard Details:");
        foreach (Event e in eventList)
        {
            e.GetStandardDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Short Description:");
        foreach (Event e in eventList)
        {
            e.GetShortDescription();
            Console.WriteLine();
        }

        Console.WriteLine("Full Details:");
        foreach (Event e in eventList)
        {
            e.GetFullDetails();
            Console.WriteLine();
        }
    }

}