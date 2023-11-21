using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        int choice = 0;
        List<Goal> goalList = new List<Goal>();

        while (choice != 6)
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. List Goals");
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
                if (goalList.Count == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    int count = 1;
                    foreach (Goal goal in goalList)
                    {
                        Console.WriteLine($"{count}. {goal.ToString()}");
                        count++;
                    }
                    Console.WriteLine();
                }
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

            }

        }
    }
}