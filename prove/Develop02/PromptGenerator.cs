public class PromptGenerator
{
	public PromptGenerator()
	{
	}

	public string GetPrompt()
	{
		List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?",
	"How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today. What would it be?",
 	"What new things did I learn today?", "What would you like to say to the future you?"};
		Random random = new Random();
		int index = random.Next(prompts.Count);
		string prompt = prompts[index];
		return prompt;
	}
}
