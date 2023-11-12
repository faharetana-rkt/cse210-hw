using System;

class Program
{
    static void Main(string[] args)
    {
        //This makes the unicode character display properly on the console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        int choice = 0;
        int breathe = 0;
        int reflect = 0;
        int list = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Show Activity Log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu:  ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breathing.Run();
                breathe++;
            }
            else if (choice == 2)
            {
                reflection.Run();
                reflect++;
            }
            else if (choice == 3)
            {
                listing.Run();
                list++;
            }
            else if (choice == 4)
            {
                Console.WriteLine("Number of activity done this session: ");
                Console.WriteLine($"1. Breathing activity: {breathe}");
                Console.WriteLine($"2. Reflection activity: {reflect}");
                Console.WriteLine($"3. Listing activity: {list}");
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
