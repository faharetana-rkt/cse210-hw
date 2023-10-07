using System;
using System.IO;

public class Journal
{
	public Journal()
	{
	}

	public void AddEntry(string entry, List<string> list)
	{
		list.Add(entry);
	}

	public void Display(List<string> list)
	{
		foreach (string entry in list)
		{
			Console.WriteLine(entry);
		};
	}

	public void Load(string fileName, List<string> list)
	{
		string[] lines = System.IO.File.ReadAllLines(fileName);
		foreach (string line in lines)
		{
			list.Add(line);
		}
	}

    public void Save(string fileName, List<string> list)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in list)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

}