using System.Collections.Generic;
using System;

namespace SortSearch
{
	public class Wes_Search : ISearch
	{
		private List<string> _words;

		public Wes_Search()
		{
			_words = new List<string>();
		}

		public void LoadWordSet(IEnumerable<string> unorderedWordSet)
		{
			foreach (var word in unorderedWordSet)
			{
				_words.Add(word);
			}
		}

		public IEnumerable<string> GetOrderedWordSet()
		{
			var j = 0;
			for (int i = 1; i < _words.Count; i++)
			{
				// Get the current word and the previous word
				var thisWord = _words[i];
				var previousWord = _words[i -1];
				// Get the character values to compare
				var thisWordCharVal = char.GetNumericValue(thisWord[0]);
				var previousWordCharVal = char.GetNumericValue(previousWord[0]);
				if (thisWordCharVal < previousWordCharVal)
					Swap(i, i - 1);
			}
			return _words;
		}

		public bool WordExistsInSet(string word)
		{
			return false;
		}

#region Peek

		/// <summary>Take a peek at the private unordered word set</summary>
		public string Peek()
		{
			return String.Join(", ", _words);
		}

#endregion

#region Private methods

		private void Swap(int i, int j)
		{
			_words.Insert(j, _words[i]);
			_words.Insert(i, _words[j]);
		}

#endregion
	}
}