using System.Linq;
using NUnit.Framework;

namespace SortSearch.Tests
{
	[TestFixture]
	class Wes_SearchTest
	{
		[Test]
		public void GetOrderedWordSet_ReturnsOrderedWordSet()
		{
			var unordered = new string[] { "zzz", "aaa", "ccc", "bbb", "iii" };
			var search = new Wes_Search();
			search.LoadWordSet(unordered);
			var ordered = search.GetOrderedWordSet().ToList();
			Assert.AreEqual(ordered[0], "aaa");
			Assert.AreEqual(ordered[4], "zzz");
		}

		[Test]
		public void WordExistsInSet_FindsWord()
		{
			var unordered = new string[] { "zzz", "aaa", "ccc", "bbb", "iii" };
			var search = new Wes_Search();
			search.LoadWordSet(unordered);
			var _ = search.GetOrderedWordSet();
			Assert.IsTrue(search.WordExistsInSet("aaa"));
		}
	}
}
