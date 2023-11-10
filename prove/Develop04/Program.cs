using System;

class Program
{
    static void Main(string[] args)
    {
        //This makes the unicode character display properly on the console
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Activity activity = new Activity("game", "Let's play a game");
		// activity.CountDownTimer(6);
        // activity.ShowSpinner(8);
        //Console.WriteLine("©");
        BreathingActivity breathe = new BreathingActivity();
        breathe.Run();

    }
}