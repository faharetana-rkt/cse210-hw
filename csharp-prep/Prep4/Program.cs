using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine ("Enter a list of numbers, type 0 when finished");

        int number = -1;
        int sum = 0;
        int largest = 0;
        int smallestPos = 1000;

        while (number!= 0)
        {
            Console.Write("Enter number: ");
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);
			if (number != 0)
			{
            	numbers.Add(number);
			}
        }

        foreach (int Number in numbers)
        {
            sum += Number;
        }

        foreach (int Number in numbers)
        {
            if (Number > largest)
            {
                largest = Number;
            }
        }

        double average = Queryable.Average(numbers.AsQueryable());

        foreach (int Number in numbers)
        {
            if (Number > 0 && Number < smallestPos)
            {
                smallestPos = Number;
            }
        }

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        Console.WriteLine("The sorted list is: ");
        foreach (int Number in numbers)
        {
            Console.WriteLine(Number);
        }
    }
}