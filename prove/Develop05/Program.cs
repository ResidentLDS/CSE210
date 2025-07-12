using System;
using System.Net;
using System.Runtime.CompilerServices;
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
        int earned = 0;

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
                                    goalList.Add(myMenu.NewEternalGoal());
                                    break;
                                }
                            case 3:
                                {
                                    goalList.Add(myMenu.NewChecklistGoals());
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Please type a number 1-3");
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
                            Console.WriteLine($"{count}. {g.GetCompletion()} {g.GetTitle()} {g.GetDescription()}");
                            count += 1;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Write("What is the name of the goal file? ");
                        string file = Console.ReadLine();
                        using (StreamWriter outputFile = new StreamWriter(file))
                        {

                            outputFile.WriteLine(points);
                            foreach (Goal g in goalList)
                            {
                                outputFile.WriteLine(g.GetSaveString());
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        Console.Write("What is the name of the goal file? ");
                        string file = Console.ReadLine();
                        List<string> lines = File.ReadAllLines(file).ToList();
                        points += int.Parse(lines[0]);
                        lines.RemoveAt(0);
                        foreach (string g in lines)
                        {
                            string[] parts = g.Split(",");
                            for (int i = 0; i < parts.Length; i++)// without this there would be spaces at the beining of the title and description
                            {
                                parts[i] = parts[i].Trim();
                            }
                            if (parts[0] == "EternalGoal")
                            {
                                EternalGoal goals = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                                goalList.Add(goals);
                            }
                            else if (parts[0] == "ChecklistGoal")
                            {
                                ChecklistGoal Goals = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[7]));
                                Goals.GetAmount(int.Parse(parts[6]));
                                if (bool.Parse(parts[4]) == true)
                                {
                                    Goals.MarkComplete();
                                }
                                goalList.Add(Goals);
                            }
                            else
                            {
                                SimpleGoal goals = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                                if (bool.Parse(parts[4]) == true)
                                {
                                    goals.MarkComplete();
                                }
                                goalList.Add(goals);
                            }
                        }

                            break;
                    }
                case 5:
                    {
                        Console.WriteLine("The uncompleted goals are:");
                        int count = 1;
                        foreach (Goal g in goalList)
                        {
                            Console.WriteLine($"{count}. {g.GetTitle()}");
                            count += 1;
                        }
                        Console.Write("What goal did you accomplish? ");
                        int input = int.Parse(Console.ReadLine());
                        earned = goalList[input - 1].CompleteGoal();
                        Console.WriteLine($"Congratulations! You have earned {earned} points!");
                        points += earned;
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