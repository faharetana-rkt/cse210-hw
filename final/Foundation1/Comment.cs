public class Comment
{
	private string _name;
	private string _comment;
	
	public Comment(string name, string comment)
	{
		_name = name;
		_comment = comment;
	}
	
	public string ToStr()
	{
		return $"--{_name}-- {_comment}";
	}
}
