using System;

namespace SortSearch
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = new string[] { "zzz", "aaa", "ccc", "bbb", "iii" };

			// Get an instance of Wes_Search to do the stuff
			var search = new Wes_Search();
			// Load the word set
			search.LoadWordSet(words);
			Console.WriteLine(search.Peek());
			// Sort the word set
			var orderedWords = search.GetOrderedWordSet();
			Console.WriteLine(search.Peek());
			// Find a word
			var wordToFind = "iii";
			var found = search.WordExistsInSet(wordToFind);
			// Write the result to stdout
			Console.WriteLine(string.Format("Does the word exist? {0}", found));
		}
	}
}