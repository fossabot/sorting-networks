﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingNetworks.Tests
{
	[TestClass]
	public class SNTests : SNTestsBase
	{
		[TestMethod]
		public void SN_Array_Ascending_Comparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SN.SortAscending(actual);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Descending_Comparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SN.SortDescending(actual);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Descending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansAscending(length, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual);

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Descending_Comparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansDescending(length, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual);

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansAscending(length, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Descending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansDescending(length, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortAscending(actual);
			});
		}

		[TestMethod]
		public void SN_Array_Descending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortDescending(actual);
			});
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Array_Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateSpansAscending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual);
			});
		}

		[TestMethod]
		public void SN_Span_Descending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateSpansDescending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual);
			});
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateSpansAscending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Span_Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateSpansDescending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparable_ArrayNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				int[] actual = null;

				SN.SortAscending(actual);
			});
		}

		[TestMethod]
		public void SN_Array_Descending_Comparable_ArrayNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				int[] actual = null;

				SN.SortDescending(actual);
			});
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparison_ArrayNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				int[] actual = null;

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Array_Descending_Comparison_ArrayNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				int[] actual = null;

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysAscending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortAscending(actual, comparison: null);
			});
		}

		[TestMethod]
		public void SN_Array_Descending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysDescending(SN.MinLength - 1, out int[] expected, out int[] actual);

				SN.SortDescending(actual, comparison: null);
			});
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateSpansAscending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual, comparison: null);
			});
		}

		[TestMethod]
		public void SN_Span_Descending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateSpansDescending(SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual, comparison: null);
			});
		}
	}
}
