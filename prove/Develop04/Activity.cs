public class Activity
{
    private string _description;
    private string _name;
    protected int _durationInSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void ClearCharacter(int charCount)
    {
        string space = new string(' ', charCount);
        Console.Write($"\b{space}\b");
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("How long in seconds would you like for your session? ");
        Console.WriteLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        Console.WriteLine(
            $"You have completed another {_durationInSeconds} seconds of the {_name}."
        );
        Console.WriteLine();
    }

    protected void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            ClearCharacter(1);
        }
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animationString = new List<string> { "▲", "►", "▼", "◄"};
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[i]);
            Thread.Sleep(750);
            ClearCharacter(1);
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
}
