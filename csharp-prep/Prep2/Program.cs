using System;

class Program
{
    static void Main(string[] args)
    {
        /** This program asks for the user's Grade percentage's
        and through a series of if and else if, converts the grade
        to a letter with a minus or plus.
         **/
        Console.Write("What is your grade percentage? ");
		string textGrade = Console.ReadLine();
		int grade = int.Parse(textGrade);

		string letter = "";
		string sign = "";

		if (grade >= 90)
		{
			letter = "A";
		}
		else if (grade >= 80 && grade < 90)
		{
			letter = "B";
		}
		else if (grade >= 70 && grade < 80)
		{
			letter = "C";
		}
		else if (grade >= 60 && grade < 70)
		{
			letter = "D";
		}
		else
		{
			letter = "F";
		}

		if ((grade % 10) >=7 )
		{
			if (grade >= 90 || grade <= 60)
			{
				sign = "";
			}
			else
			{
				sign = "+";
			}
		}
		else if ((grade % 10) <3)
		{
			if (grade >= 90 || grade <= 60)
			{
				sign = "";
			}
			else
			{
				sign = "-";
			}
		}
		else
		{
			sign = "";
		}

		Console.WriteLine($"Your grade is {letter}{sign}.");

		if (grade >= 70)
		{
			Console.WriteLine("Congrats you passed the class with flying colors.");
		}
		else
		{
			Console.WriteLine("Unfortunately you didn't pass the class, please try again next semester.");
		}
    }
}