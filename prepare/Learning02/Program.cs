using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear= 2022;

        Job job2 = new Job();
        job2._jobTitle = "Game Developer";
        job2._company = "Sony";
        job2._startYear = 2016;
        job2._endYear= 2021;

        Resume myResume = new Resume();
        myResume.name = "John Smith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        job1.Print_Job(); 
        job2.Print_Job();
    }
}