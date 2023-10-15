using System;
using System.IO;

public class Journal
{
	public List<Entry> _entries = new List<Entry>();

	public Journal()
	{
	}

	public void AddEntry(Entry entry)
	{
		_entries.Add(entry);
	}

	public void Display()
	{
		foreach (Entry entry in _entries)
		{
			string strEntry = entry.GetDisplayString();
			Console.WriteLine(strEntry);
		};
	}

	public void Load(string fileName)
	{
		string[] lines = System.IO.File.ReadAllLines(fileName);
		foreach (string line in lines)
		{
			string[] parts = line.Split(",");
			Entry entry = new Entry();
			entry._date = parts[0];
			entry._hour = parts[1];
			entry._prompt = parts[2];
			entry._response = parts[3];
			_entries.Add(entry);
		}
	}

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._hour},{entry._prompt},{entry._response}");
            }
        }
    }

}