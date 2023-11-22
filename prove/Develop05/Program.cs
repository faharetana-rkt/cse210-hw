using System;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        int expPoints = 500;
        int choice = 0;
        string level = "Level 1";
        List<Goal> goalList = new List<Goal>();

        void CheckLevel()
        {
            if (totalPoints < 500)
            {
                level = "Level 1";
            }
            else if (totalPoints >= 500 && totalPoints < 1000)
            {
                level = "Level 2";
            }
            else if (totalPoints >= 1000 && totalPoints < 1500)
            {
                level = "Level 3";
            }
            else if (totalPoints >= 1500 && totalPoints < 2000)
            {
                level = "Level 4";
            }
            else if (totalPoints >= 2000 && totalPoints < 2500)
            {
                level = "Level 5";
            }
        }

        void ExpNeeded()
        {
            if (level == "Level 1")
            {
                expPoints = 500 - totalPoints;
            }
            else if (level == "Level 2")
            {
                expPoints = 1000 - totalPoints;
            }
            else if (level == "Level 3")
            {
                expPoints = 1500 - totalPoints;
            }
            else if (level == "Level 4")
            {
                expPoints = 2000 - totalPoints;
            }
            else if (level == "Level 5")
            {
                expPoints = 2500 - totalPoints;
            }
        }


        while (choice != 6)
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine($"You are now {level}. You need {expPoints} more points to reach the next level.");
            CheckLevel();
            ExpNeeded();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of Goal would you like to create? ");
                int goalChoice = int.Parse(Console.ReadLine());
                if (goalChoice == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal mySimpleGoal = new SimpleGoal(name, description, points);
                    goalList.Add(mySimpleGoal);
                    Console.WriteLine();
                }
                else if (goalChoice == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal myEternalGoal = new EternalGoal(name, description, points);
                    goalList.Add(myEternalGoal);
                    Console.WriteLine();
                }
                else if (goalChoice == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal myChecklistGoal = new ChecklistGoal(name, description, points, times, bonus);
                    goalList.Add(myChecklistGoal);
                    Console.WriteLine();
                }
            }
            else if (choice == 2)
            {
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goalList)
                {
                    Console.WriteLine($"{count}. {goal.ToStr()}");
                    count++;
                }
                Console.WriteLine();

            }
            else if (choice == 3)
            {
                Console.Write("What is the name for the goal file? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{totalPoints}");
                    foreach (Goal goal in goalList)
                    {
                        outputFile.WriteLine(goal.ToSavedStr());
                    }
                }
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    if (parts.Length == 1)
                    {
                        totalPoints = int.Parse(parts[0]);
                    }
                    else
                    {
                        if (parts[0] == "SimpleGoal")
                        {
                            string[] items = parts[1].Split(",");
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);
                            bool isFinished = false;
                            if (items[3] == "false")
                            {
                                isFinished = false;
                            }
                            else
                            {
                                isFinished = true;
                            }

                            SimpleGoal mySimpleGoal = new SimpleGoal(name, description, points);
                            mySimpleGoal.SetIsFinished(isFinished);
                            goalList.Add(mySimpleGoal);
                        }
                        else if (parts[0] == "EternalGoal")
                        {
                            string[] items = parts[1].Split(",");
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);
                            EternalGoal myEternalGoal = new EternalGoal(name, description, points);
                            goalList.Add(myEternalGoal);
                        }
                        else if (parts[0] == "ChecklistGoal")
                        {
                            string[] items = parts[1].Split(",");
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);
                            int bonusPoints = int.Parse(items[3]);
                            int timesToComplete = int.Parse(items[4]);
                            int timesCompleted = int.Parse(items[5]);
                            ChecklistGoal myChecklistGoal = new ChecklistGoal(name, description, points, timesToComplete, bonusPoints);
                            myChecklistGoal.SetTimesCompleted(timesCompleted);
                            goalList.Add(myChecklistGoal);
                        }
                    }
                }
            }

            else if (choice == 5)
            {
                if (goalList.Count == 0)
                {
                    Console.WriteLine("You haven't created any goals yet. Go create some and then come back.");
                }
                else
                {
                    int count = 1;
                    Console.WriteLine("Which goal did you accomplish? ");
                    foreach (Goal goal in goalList)
                    {
                        Console.WriteLine($"{count}. {goal.ToStr()}");
                        count++;
                    }

                    int index = int.Parse(Console.ReadLine());
                    if (index > goalList.Count || index <= 0)
                    {
                        Console.WriteLine($"Choose a number between 1 and {goalList.Count}.");
                    }
                    else
                    {
                        index = index - 1;
                        int pointReceived = goalList[index].RecordEvent();
                        totalPoints += pointReceived;
                        Console.WriteLine($"Congratulations! You have earned {pointReceived} points!");
                        Console.WriteLine($"You now have {totalPoints} points.");
                        CheckLevel();
                        ExpNeeded();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}