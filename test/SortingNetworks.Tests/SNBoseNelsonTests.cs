namespace SortingNetworks.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBoseNelsonTests : SNTestsBase
	{
		[TestMethod]
		public void Ascending_IComparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_IComparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_IComparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Descending_IComparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Ascending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, comparison: null);
			});
		}

		[TestMethod]
		public void Descending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, comparison: null);
			});
		}
	}
}