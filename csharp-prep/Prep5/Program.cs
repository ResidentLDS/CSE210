using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int NumberSquared = 0;
        DisplayWelcome();
        string UserName = PromptUserName();
        int FaveNumber = PromptUserNumber();
        NumberSquared = SquareNumber(FaveNumber);
        DisplayResult(UserName, FaveNumber, NumberSquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to our club! Welcome to our club!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        int number = 0;
        Console.WriteLine("Please enter your favorite number: ");
        string entry = Console.ReadLine();
        number = int.Parse(entry);
        return number;
    }
    static int SquareNumber(int Number)
    {
        int squared = Number * Number;
        return squared;
    }
    static void DisplayResult(string name, int numbered, int squared)
    {
        Console.WriteLine($"{name}, the square of your favorite number, {numbered}, is {squared}."); 
    }
}