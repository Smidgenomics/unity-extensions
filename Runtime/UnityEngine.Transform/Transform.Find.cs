// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;
	using UnityEngine;

	public static partial class Transform_
	{
		/// <summary>
		/// Searches transform hierarchy recursively for the first matched condition
		/// </summary>
		/// <returns></returns>
		public static Transform Find(this Transform parent, Func<Transform, bool> predicate)
		{
			if (!parent)
			{
				return null;
			}

			if (predicate.Invoke(parent))
			{
				return parent;
			}
			foreach (Transform child in parent)
			{
				var c = Find(child, predicate);
				if (c)
				{
					return c;
				}
			}
			return null;
		}
	}
}