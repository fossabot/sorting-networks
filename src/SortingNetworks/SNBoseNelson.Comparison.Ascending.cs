﻿namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBoseNelson
	{
		/// <summary>
		/// Sorts a collection of 2 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort2Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfGreater(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort3Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			SwapIfGreater(ref p1, ref p2, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 4 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort4Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort5Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p3, ref p4, comparison);
			SwapIfGreater(ref p2, ref p4, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
			SwapIfGreater(ref p0, ref p3, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p1, ref p4, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 6 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort6Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			SwapIfGreater(ref p1, ref p2, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p4, ref p5, comparison);
			SwapIfGreater(ref p3, ref p5, comparison);
			SwapIfGreater(ref p3, ref p4, comparison);
			SwapIfGreater(ref p0, ref p3, comparison);
			SwapIfGreater(ref p1, ref p4, comparison);
			SwapIfGreater(ref p2, ref p5, comparison);
			SwapIfGreater(ref p2, ref p4, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
		}

		/// <summary>
		/// Sorts a collection of 7 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort7Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);

			SwapIfGreater(ref p1, ref p2, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p3, ref p4, comparison);
			SwapIfGreater(ref p5, ref p6, comparison);
			SwapIfGreater(ref p3, ref p5, comparison);
			SwapIfGreater(ref p4, ref p6, comparison);
			SwapIfGreater(ref p4, ref p5, comparison);
			SwapIfGreater(ref p0, ref p4, comparison);
			SwapIfGreater(ref p0, ref p3, comparison);
			SwapIfGreater(ref p1, ref p5, comparison);
			SwapIfGreater(ref p2, ref p6, comparison);
			SwapIfGreater(ref p2, ref p5, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p2, ref p4, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
		}

		/// <summary>
		/// Sorts a collection of 8 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort8Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);

			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p1, ref p2, comparison);
			SwapIfGreater(ref p4, ref p5, comparison);
			SwapIfGreater(ref p6, ref p7, comparison);
			SwapIfGreater(ref p4, ref p6, comparison);
			SwapIfGreater(ref p5, ref p7, comparison);
			SwapIfGreater(ref p5, ref p6, comparison);
			SwapIfGreater(ref p0, ref p4, comparison);
			SwapIfGreater(ref p1, ref p5, comparison);
			SwapIfGreater(ref p1, ref p4, comparison);
			SwapIfGreater(ref p2, ref p6, comparison);
			SwapIfGreater(ref p3, ref p7, comparison);
			SwapIfGreater(ref p3, ref p6, comparison);
			SwapIfGreater(ref p2, ref p4, comparison);
			SwapIfGreater(ref p3, ref p5, comparison);
			SwapIfGreater(ref p3, ref p4, comparison);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(ref T p0, in int length, Comparison<T> comparison)
		{
			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

			switch (length)
			{
				case 2: Sort2Ascending(ref p0, comparison); break;
				case 3: Sort3Ascending(ref p0, comparison); break;
				case 4: Sort4Ascending(ref p0, comparison); break;
				case 5: Sort5Ascending(ref p0, comparison); break;
				case 6: Sort6Ascending(ref p0, comparison); break;
				case 7: Sort7Ascending(ref p0, comparison); break;
				case 8: Sort8Ascending(ref p0, comparison); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}