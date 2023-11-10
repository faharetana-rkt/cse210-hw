public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        ) { }

    private void BreatheIn()
    {
        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(duration);
        string start = "b   r   e   a   t   h   e    i   n.";
        string startSpaceMinus1 = "b  r  e  a  t  h  e   i  n.";
        string startSpaceMinus2 = "b r e a t h e  i n.";
        string startWithoutSpace = "breathe in.";
        int charCount = start.Length;
        //while (DateTime.Now < endTime)
        Console.Write(start);
        Thread.Sleep(1000);
        ClearCharacter(charCount);
        Console.Write(startSpaceMinus1);
        Thread.Sleep(1000);
        ClearCharacter(charCount);
        Console.Write(startSpaceMinus2);
        Thread.Sleep(1000);
        ClearCharacter(charCount);
        Console.Write(startWithoutSpace);
        Thread.Sleep(1000);
    }

    private void BreatheOut()
    {
        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(duration);
        string start = "Now breathe out.";
        string startWith1Space = "N o w  b r e a t h e  o u t.";
        string startWith2Space = "N  o  w   b  r  e  a  t  h  e   o  u  t.";
        string endString = "N   o   w    b   r   e   a   t   h   e    o   u   t.";
        int countEnd = endString.Length;
        int countStart1 = startwith1Space.Length;
        int countStart2 = startWith2Space.Length;
        int countStart = start.Length;
        //while (DateTime.Now < endTime)
        Console.Write(start);
        Thread.Sleep(1000);
        ClearCharacter(countStart);
        Console.Write(startWith1Space);
        Thread.Sleep(1000);
        ClearCharacter(countStart1);
        Console.Write(startWith2Space);
        Thread.Sleep(1000);
        ClearCharacter(countStart2);
        Console.Write(endString);
        Thread.Sleep(1000);
        Console.Write(startWith1Space);
        Thread.Sleep(1000);
        ClearCharacter(countStart1);
        Console.Write(startWith2Space);
        Thread.Sleep(1000);
        ClearCharacter(countStart2);
        Console.Write(endString);
    }

    public void Run()
    {
        DisplayStartingMessage();
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(8);
        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        //BreatheIn(2);
        //BreatheOut(4);
        //Console.WriteLine();

        double division = _durationInSeconds / 10;
        double iteration = Math.Ceiling(division);

        for (int i = 1; i <= iteration; i++)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(8);
        Console.Clear();
    }
}
