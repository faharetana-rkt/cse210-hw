using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
		
		Running run = new("27 Nov 2023", 40, 5.5);
		activities.Add(run);
		Swimming swim = new("28 Nov 2023", 15, 5);
		activities.Add(swim);
		Cycling cycle = new("29 Nov 2023", 30, 15);
		activities.Add(cycle);
		
		foreach (Activity activity in activities)
		{
			Console.WriteLine(activity.GetSummary());
		}
	
    }
}