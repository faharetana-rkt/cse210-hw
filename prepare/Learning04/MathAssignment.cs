public class MathAssignment : Assignment
{
	private string _textbookSection;
	private string _problems;

	public MathAssignment(string textBook, string problems, string studentName, string topic) : base(studentName, topic)
	{
		_textbookSection = textBook;
		_problems = problems;
	}

	public string GetHomeWorkList()
	{
		return $"Section {_textbookSection} Problemss {_problems}";
	}
}