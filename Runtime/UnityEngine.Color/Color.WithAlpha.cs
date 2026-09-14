// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Color_
	{
		/// <summary>
		/// Sets alpha value of color and returns it
		/// </summary>
		public static Color WithAlpha(this Color v, float a)
		{
			v.a = a;
			return v;
		}
	}
}