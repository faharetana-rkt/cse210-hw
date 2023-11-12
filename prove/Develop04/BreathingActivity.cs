public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    { }

    private void BreatheIn()
    {
        string start = "b   r   e   a   t   h   e    i   n.";
        string startSpaceMinus1 = "b  r  e  a  t  h  e   i  n.";
        string startSpaceMinus2 = "b r e a t h e  i n.";
        string endString = "breathe in.";
        int startCount = start.Length + 20;
        Console.Write(start);
        Thread.Sleep(1000);
        ClearCharacter(startCount);
        Console.Write("\r" + startSpaceMinus1);
        Thread.Sleep(1000);
        ClearCharacter(startCount);
        Console.Write("\r" + startSpaceMinus2);
        Thread.Sleep(1000);
        ClearCharacter(startCount);
        Console.Write("\r" + endString);
        Thread.Sleep(1000);
        ClearCharacter(startCount);
        Console.WriteLine("\r" + start);


    }

    private void BreatheOut()
    {
        string start = "Now breathe out.";
        string startWith1Space = "N o w  b r e a t h e  o u t.";
        string startWith2Space = "N  o  w   b  r  e  a  t  h  e   o  u  t.";
        string endString = "N   o   w    b   r   e   a   t   h   e    o   u   t.";
        int countEnd = endString.Length + 10;
        Console.Write(start);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.Write("\r" + startWith1Space);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.Write("\r" + startWith2Space);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.Write("\r" + endString);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.Write("\r" + startWith1Space);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.Write("\r" + startWith2Space);
        Thread.Sleep(1000);
        ClearCharacter(countEnd);
        Console.WriteLine("\r" + endString);
    }

    public void Run()
    {
        DisplayStartingMessage();
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(8);

        //This is to calculate how many iterations the for loop shall make to match the duration requested
        //by the user
        double division = _durationInSeconds / 10;
        double iteration = Math.Ceiling(division);

        //Each iteration of breathein & breatheout has been set to a fixed 10 seconds.
        for (int i = 1; i <= iteration; i++)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
