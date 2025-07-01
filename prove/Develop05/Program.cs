using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static bool runProgram = true;
    public static bool annoyance = false;
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        while (runProgram)
        {
            int response1 = myMenu.PrintMenu(annoyance);
            annoyance = false;
            switch (response1)
            {
                case 1:
                    {
                        int response2 = myMenu.GoalChoice();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        runProgram = false;
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        annoyance = true;
                        break;
                    }
            }

        }
        Console.WriteLine("Goodbye!");
    }
}