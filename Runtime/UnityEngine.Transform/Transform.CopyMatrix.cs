// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Transform_
	{
		/// <summary>
		/// Copy global transform matrix
		/// </summary>
		public static Matrix4x4 CopyMatrix(this Transform t) => Matrix4x4.TRS(t.position, t.rotation, t.lossyScale);

		/// <summary>
		/// Copy local transform matrix
		/// </summary>
		public static Matrix4x4 CopyMatrixLocal(this Transform t) => Matrix4x4.TRS(t.localPosition, t.localRotation, t.localScale);
	}
}