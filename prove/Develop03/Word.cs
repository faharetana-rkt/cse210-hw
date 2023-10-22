public class Word
	{
		private string _word;
		private string _hiddenWord;
		private bool _visible = true;

		public Word (string word)
		{
			_word = word;
		}

		public void Hide ()
		{
			//This function creates a new string with underscores that matches the length of the word
			//and sets the _hiddenword attributes and the visibility to false
			string hiddenWord = new string('_', _word.Length);
			_hiddenWord = hiddenWord;
			_visible = false;
		}

		public void Show()
		{
			//This function sets the visibility to true
			_visible = true;
		}

		public string GetRenderedWord()
		{
			//This function returns the _word or the _hiddenWord depending on the visibility of the word
			if (_visible)
			{
				return _word;
			}
			else
			{
				return _hiddenWord;
			}
		}

		public bool IsVisible()
		{
			//This function returns true if the function is visible
			return _visible;
		}
	}