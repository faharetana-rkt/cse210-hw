public class ListingActivity : Activity
{
    private List<string> PROMPTS = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _userInput = new List<string>();

    public ListingActivity()
        : base(
            "ListingActivity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(PROMPTS.Count);
        return PROMPTS[randomIndex];

    }

    public void Run()
    {
        DisplayStartingMessage();
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(8);
        Console.WriteLine();
        Console.WriteLine("List as many response you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in: ");
        CountDownTimer(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            _userInput.Add(userInput);
            //Console.WriteLine($"Time remaining: {(endTime - DateTime.Now).TotalSeconds} seconds");

        }
        int inputCount = _userInput.Count;
        Console.WriteLine($"You listed {inputCount} items!");
        DisplayEndingMessage();
    }
}
