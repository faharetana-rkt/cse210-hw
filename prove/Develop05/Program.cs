using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simple = new SimpleGoal("go running", "run 15 mn", 100);
        Console.WriteLine(simple.ToStr());
        Console.WriteLine(simple.ToSavedStr());
        simple.RecordEvent();
        Console.WriteLine(simple.ToStr());

    }
}