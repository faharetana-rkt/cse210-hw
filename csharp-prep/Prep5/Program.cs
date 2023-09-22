using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
		string name = PromptUserName();
		int favNum = PromptUserNumber();
		double squared = SquareNumber(favNum);
		DisplayResult(name, squared);
    }

    static void DisplayWelcome()
	{
		Console.WriteLine("Welcome to the Program.");
	}

    static string PromptUserName()
	{
		Console.Write("What is your name? ");
		string userName = Console.ReadLine();
		return userName;
	}

	static int PromptUserNumber()
	{
		Console.Write("What is your favorite number? ");
		string strFavNum = Console.ReadLine();
		int FavNum = int.Parse(strFavNum);
		return FavNum;
	}

	static double SquareNumber(int number)
	{
		double squared = Math.Sqrt(number);
		return squared;
	}

	static void DisplayResult(string name, double squared)
	{
		Console.WriteLine($"Brother {name}, the square root of your number is {squared}.");
	}
}