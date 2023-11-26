using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressLecture = new("Conference Room N°10", "525 South Center St. Rexburg", "ID 83460");
        Lecture lecture = new("Human psychology", "Learn more about how humans interact with each other during this lecture.", "30 November 2023", "04:00 pm", addressLecture, "Lecture", "Dr Mary Jane", 100);
        Console.WriteLine("Standard Details :");
        Console.WriteLine(lecture.StandardDetail());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Address addressOutdoor = new("Rockfeller park", "75 Battery Place New York", "NY 10280");
        OutdoorGathering outdoorGathering = new("Book Fair", "Come and enjoy reading books for free and buy them at a discounted prices", "13 December 2023", "10:00 am", addressOutdoor, "Outdoor Gathering", "Sunny");
        Console.WriteLine("Standard Details :");
        Console.WriteLine(outdoorGathering.StandardDetail());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(outdoorGathering.ShortDescription());
        Console.WriteLine();

        Address addressReception = new("Angler", "132 The Embarcadero San Francisco", "CA 94105");
        Reception reception = new("Charity Gala", "Your contribution will make the lives of other better", "24 December 2023", "08:00 pm", addressReception, "Reception", "Dear Guest,\nWe hope this message finds you well. We are excited to invite you to a gala of charity to better the lives of homeless people.\nBest regards,");
        Console.WriteLine("Standard Details :");
        Console.WriteLine(reception.StandardDetail());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();
    }
}