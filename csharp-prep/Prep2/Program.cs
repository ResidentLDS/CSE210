using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int grade_perc = int.Parse(grade);

        string letter_print = "";

        if (grade_perc >= 90)
        {
            letter_print = "A";
        }
        else if (grade_perc >= 80)
        {
            letter_print = "B";
        }
        else if (grade_perc >= 70)
        {
            letter_print = "C";
        }
        else if (grade_perc >= 60)
        {
            letter_print = "D";
        }
        else
        {
            letter_print = "F";
        }
        if (grade_perc >= 60)
        {

        }
        Console.WriteLine($"Your grade is {letter_print}");
        if (letter_print == "A"|| letter_print == "B"|| letter_print == "C"|| letter_print == "D")
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
    
}