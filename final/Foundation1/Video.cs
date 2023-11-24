public class Video
{
	private string _title;
	private string _author;
	private int _length;
	public List<Comment> _comments = new List<Comment>();
	
	public Video(string title, string author, int length)
	{
		_title = title;
		_author = author;
		_length = length;
	}
	
	public string ToStr()
	{
		return $"Title: {_title}; Author: {_author}; Length in Seconds: {_length}; Number of Comments: {this.GetListCount()}.";
	}
	
	public int GetListCount()
	{
		return _comments.Count;
	}
}