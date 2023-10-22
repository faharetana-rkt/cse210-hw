public class Reference
	{
		private string _book;
		private int _chapter;
		private int _verseBeginning;

		private string _verseEnd = ""; //I set the _verseEnd attribute to a string to implement the dash and ommit it if necessary

		public Reference (string book, int chapter, int verseBegin)
		{
			_book = book;
			_chapter = chapter;
			_verseBeginning = verseBegin;
		}

		public Reference (string book, int chapter, int verseBegin, string verseEnd)
		{
			_book = book;
			_chapter = chapter;
			_verseBeginning = verseBegin;
			_verseEnd = verseEnd;
		}

		public string GetReference () {
			//Returns the reference as a string, a getter
			return $"{_book} {_chapter}:{_verseBeginning}{_verseEnd}";
		}
	}