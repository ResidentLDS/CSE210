using System;

public class Resume
{
    public string_name;
    public List<Job> _jobs = new List<Job>();

    public void Print_Line()
    {
        Console.WriteLine($"Nmae {name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.print_line();
        }
    }
}