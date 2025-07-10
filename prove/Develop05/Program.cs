using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static List<Goal> goalList = new List<Goal>();
    public static bool runProgram = true;
    public static bool annoyance = false;
    public static int points = 0;
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Console.Clear();

        while (runProgram)
        {
            Console.WriteLine($"\nYou have {points} points.\n");
            int response1 = myMenu.PrintMenu(annoyance);
            annoyance = false;
            switch (response1)
            {
                case 1:
                    {
                        int response2 = myMenu.GoalChoice();
                        switch (response2)
                        {
                            case 1:
                                {
                                    goalList.Add(myMenu.NewSimpleGoal());
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
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The goals are:");
                        int count = 1;
                        foreach (Goal g in goalList)
                        {
                            Console.WriteLine($"{count}. {g.GetCompletion()} {g.GetTitle()} ({g.GetDescription()}) ");
                            count += 1;
                        }
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
                        int input = 0;

                        points += goalList[input - 1].CompleteGoal();
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