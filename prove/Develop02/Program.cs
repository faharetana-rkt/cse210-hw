using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("Please select one of these choices:");
		    Console.WriteLine("1. Write");
		    Console.WriteLine("2. Display");
		    Console.WriteLine("3. Load");
		    Console.WriteLine("4. Save");
		    Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
		    choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                string strPrompt = prompt.GetPrompt();
                Console.WriteLine(strPrompt);

                Entry entry = new Entry();
                entry._prompt = strPrompt;
                entry._response = Console.ReadLine();
                //string strEntry = entry.GetDisplayString(entry._date, entry._hour, entry._prompt, entry._response);
                //Console.WriteLine(strEntry);
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
            }
        }
    }
}