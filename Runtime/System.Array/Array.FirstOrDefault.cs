// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	public static partial class Array_
	{
		public delegate bool FilterFn<T>(in T v);
		public delegate bool FilterFn2<T, VT>(in T v, in VT v2);

		/// <summary>
		/// Array-specific alternative to LINQ
		/// </summary>
		public static T FirstOrDefault<T>(this T[] arr, FilterFn<T> filter)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (filter.Invoke(arr[i]))
				{
					return arr[i];
				}
			}
			return default;
		}
	}
}