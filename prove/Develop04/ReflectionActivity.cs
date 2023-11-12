public class ReflectionActivity : Activity
{
    private List<string> PROMPTS = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> QUESTIONS = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<int> _randomIndexPrompt = new List<int>();
    private List<int> _randomIndexQuestion = new List<int>();

    public ReflectionActivity()
        : base(
            "BreathingActivity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    { }

    private string GetRandomPrompt()
    {
        while (true)
        {
            Random random = new Random();
            int randomIndex = random.Next(PROMPTS.Count);

            if (!_randomIndexPrompt.Contains(randomIndex))
            {
                _randomIndexPrompt.Add(randomIndex);
                string prompt = PROMPTS[randomIndex];
                return prompt;
            }
            else
            {
                continue;
            }
        }
    }

    private string GetRandomQuestion()
    {
        while (true)
        {
            Random random = new Random();
            int randomIndex = random.Next(QUESTIONS.Count);

            if (!_randomIndexQuestion.Contains(randomIndex))
            {
                _randomIndexQuestion.Add(randomIndex);
                string prompt = QUESTIONS[randomIndex];
                return prompt;
            }
            else
            {
                continue;
            }
        }
    }

    private List<string> GetQuestions()
    {
        List<string> questions = new List<string>();
        for (int i = 0; i < QUESTIONS.Count; i++)
        {
            questions.Add(GetRandomQuestion());
        }
        return questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(8);
        Console.WriteLine("Consider this prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in your mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(
            "Now ponder on each of the following questions as they related to this experience."
        );
        Console.Write("You may begin in: ");
        CountDownTimer(5);
        Console.Clear();

        List<string> questionsList = GetQuestions();
        double division = _durationInSeconds / 10;
        double iteration = Math.Ceiling(division);

        for (int i = 0; i < iteration; i++)
        {
            Console.Write($"> {questionsList[i]}  ");
            ShowSpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
