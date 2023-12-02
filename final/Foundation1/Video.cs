using System;
using System.Text;

public class Video
{
	private string _title;
	private string _author;
	private int _length;

	// SMT attributes should be private or at the very lease not writable.
	private List<Comment> _comments = new List<Comment>();
	
	// SMT Create your List<Comment> and pass it into the constructor
	public Video(string title, string author, int length, List<Comment> comments)
	{
		_title = title;
		_author = author;
		_length = length;
		_comments = comments;
	}
	
	// SMT you should include the calls to Comment.ToStr() here. BTW, every object has an override method ToString() for you to do
	// what you're doing with ToStr()
	public string GetComments()
	{
		StringBuilder comments = new StringBuilder();
		foreach (Comment comment in _comments)
		{
			comments.AppendLine(comment.ToString());
		}
		return comments.ToString();
	}
	public override string ToString()
	{
		return $"Title: {_title}; Author: {_author}; Length in Seconds: {_length}; Number of Comments: {this.GetListCount()}.";
	}

	
	public int GetListCount()
	{
		return _comments.Count;
	}
}