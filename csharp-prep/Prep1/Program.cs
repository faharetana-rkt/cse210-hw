using System;

class Program
{
    static void Main(string[] args)
    {
        /**This program asks the user for his first name and last name
        to replicate the iconic line "My name is bond, James Bond". **/
        Console.Write("What is your first name? ");
		string firstName = Console.ReadLine();
		Console.Write("What is your last name? ");
		string lastName = Console.ReadLine();
		Console.WriteLine("");
		Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}