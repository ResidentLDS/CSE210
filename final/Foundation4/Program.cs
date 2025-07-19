using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        Running running_1 = new Running(12.23, 92, "04 Jan 2023");
        Swimming swimming_1 = new Swimming(45, 52.4, "29 May 2023");
        Cycling cycling_1 = new Cycling(25.33, 45, "17 Aug 2023");

        activityList.Add(running_1);
        activityList.Add(swimming_1);
        activityList.Add(cycling_1);

        foreach (Activity a in activityList)
        {
            Console.WriteLine(a.GetSummary());
            // So while looking at the requirements it asked for specific data for each, so I had running track distance, 
            // swimming laps, and cycling speed, then found the appropriate data based on what was provided. I think that's what you wanted.
        }
    }
}