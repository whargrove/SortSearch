using System.Collections.Generic;

namespace SortSearch
{
	public interface ISearch
	{
		/// <summary>Load the an unordered word set to be sorted and searched.</summary>
		/// <param name="unorderedWordSet">A set of unordered words.</param>
		/// <remarks>Checked for performance.</remarks>
		void LoadWordSet(IEnumerable<string> unorderedWordSet);
		
		/// <summary>Sorts the word set.</summary>
		/// <returns>Sorted word set.</returns>
		/// <remarks>Checked for validity.</remarks>
		IEnumerable<string> GetOrderedWordSet();
		
		/// <summary>Find word in the loaded word set.</summary>
		/// <param name="word">The word to find in the word set.</param>
		/// <returns>True if the word is found in the word set</returns>
		/// <remarks>Checked for performance and validity.</remarks>
		bool WordExistsInSet(string word);
	}
}