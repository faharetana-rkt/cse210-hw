public class Scripture
	{
		private string _reference;
		private List<Word> _scripture = new List<Word>();
        private List<int> _hiddenWordIndices = new List<int>();

		public Scripture (string scripture, Reference reference)
		{
			string[] words = scripture.Split(' ');
			foreach (string word in words)
			{
				Word scriptureWord = new Word(word);
				_scripture.Add(scriptureWord);
			}

			_reference = reference.GetReference();
		}

		//This commented code was used to test the code if it rendered the list of words properly
		/*public List<Word> getList () {
			return _scripture;
		}*/

		public void HideWords ()
		{
			//This function randomly hides three words from the list of word
			Random random = new Random();
			/*int index1 = random.Next(_scripture.Count);
			int index2 = random.Next(_scripture.Count);
			int index3 = random.Next(_scripture.Count);
			_scripture[index1].Hide();
			_scripture[index2].Hide();
			_scripture[index3].Hide();*/
			//The DRY principle was applied here to avoid repetitive codes
			/*for (int i = 0; i < 4; i++)
			{
				int index = random.Next(_scripture.Count);
				_scripture[index].Hide();
			}*/

            //Stretch Challenge
            int numberOfWordsToHide = 3;

            while (_hiddenWordIndices.Count < _scripture.Count && numberOfWordsToHide > 0)
                {
                    int randomIndex = random.Next(_scripture.Count);

                    // Check if the word at the randomIndex has not already been hidden
                    if (!_hiddenWordIndices.Contains(randomIndex))
                    {
                        _scripture[randomIndex].Hide();
                        _hiddenWordIndices.Add(randomIndex);
                        numberOfWordsToHide--;
                    }

                }
        }

        /*public void GenerateNumberList()
        {
            for (int i = 0; i < _scripture.Count; i++)
            {
                _hiddenWordIndices.Add(i);
            }
        }*/

		public string GetRenderedText ()
		{
			//To get the text, a list of string is created and we had the getter
			//get the string to add to the string list and then have them joined into one big string
			List<string> StringList = new List<string>();
			foreach (Word word in _scripture)
			{
				StringList.Add(word.GetRenderedWord());
			}
			string mergedString = string.Join(" ", StringList);
			return $"{_reference} {mergedString}";
		}

		public bool IsCompletelyHidden()
		{
			//This function returns true if all words are completely hidden
			//It checks if each word is still visible
			//Failed coditional
			/*int hiddenWordCount = 0;
			foreach (Word word in _scripture)
			{
				if (word.IsVisible())
				{
					hiddenWordCount++;
				}
			}
			if (hiddenWordCount == _scripture.Count)
			{
				return true;
			}
			else
			{
				return false;
			}*/
			foreach (Word word in _scripture)
        	{
            	if (word.IsVisible())
            	{
                	return false; // If any word is visible, return false immediately
            	}
        	}

        	// If we reach this point, all words are hidden
        	return true;
		}

	}