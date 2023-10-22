using System;

class Program
{
    static void Main(string[] args)
    {
        /*Word sample = new Word("Saints");
		Console.WriteLine(sample.GetRenderedWord());
		sample.Hide();
		Console.WriteLine(sample.GetRenderedWord());
		sample.Show();
		Console.WriteLine(sample.GetRenderedWord());

		Reference sampleRef = new Reference("Matthew", 3, 1);
		Console.WriteLine(sampleRef.GetReference());
		Reference sampleRef1 = new Reference ("Matthew", 3, 1, "-4 ");
		Console.WriteLine(sampleRef1.GetReference());

		Scripture memorize = new Scripture ("In those days John the Baptist came, preaching in the wilderness of Judea", sampleRef);*/
		/*foreach (Word word in memorize.getList())
		{
			Console.WriteLine(word.GetRenderedWord());
		}*/
		/*memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		Console.WriteLine(memorize.IsCompletelyHidden());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		memorize.HideWords();
		Console.WriteLine(memorize.GetRenderedText());
		Console.WriteLine(memorize.IsCompletelyHidden());*/

		Reference scriptureRef = new Reference("1Corinthians", 13, 4);
		Scripture scripture = new Scripture("Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up.", scriptureRef);
        //scripture.GenerateNumberList();
		string response = "";
		while (!scripture.IsCompletelyHidden() && response != "quit")
		{
			Console.Clear();
			Console.WriteLine(scripture.GetRenderedText());
			scripture.HideWords();
			Console.WriteLine();
			Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
			response = Console.ReadLine();
		}
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine();
    }
}