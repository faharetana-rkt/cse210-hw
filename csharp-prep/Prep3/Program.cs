using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
		
		while (response == "yes")
		{
			int numGuess = 0;
			int Guess = -1;
			Random randomGenerator = new Random();
			int MagicNum = randomGenerator.Next(1, 100);
			Console.WriteLine ($"Welcome to the Number Guessing game {MagicNum}.");
			while (MagicNum != Guess)
			{
				numGuess += 1;
				Console.Write("What is your Guess?");
				string strGuess = Console.ReadLine();
				Guess = int.Parse(strGuess);

				if (MagicNum > Guess)
				{
					Console.WriteLine("Higher.");
				}
				else if (MagicNum < Guess)
				{
					Console.WriteLine("Lower.");
				}
				else
				{
					Console.WriteLine("You guessed it.");
				}
			}
			Console.WriteLine($"The number of your guesses is: {numGuess}.");
			Console.Write("Do you still want to play?");
			response = Console.ReadLine();
        }
    }
}