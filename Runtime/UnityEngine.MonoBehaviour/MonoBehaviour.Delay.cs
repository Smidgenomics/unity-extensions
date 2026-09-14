// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;
	using System;
	using System.Collections;

	public static partial class MonoBehaviour_
	{
		/// <summary>
		/// Executes callback after delay
		/// </summary>
		public static Coroutine Delay(this MonoBehaviour b, in float delay, Action afterDelay)
		{
			return b.Delay(new WaitForSeconds(delay), afterDelay);
		}

		/// <summary>
		/// Executes callback after delay
		/// </summary>
		public static Coroutine Delay(this MonoBehaviour c, WaitForSeconds delay, Action afterDelay)
		{
			return c.StartCoroutine(YieldRoutine(delay, afterDelay));
		}

		/// <summary>
		/// Executes callback at the end of frame
		/// </summary>
		public static Coroutine DelayTilEndOfFrame(this MonoBehaviour c, Action afterDelay)
		{
			return c.StartCoroutine(YieldRoutine(new WaitForEndOfFrame(), afterDelay));
		}

		
		// delay helper
		private static IEnumerator YieldRoutine(YieldInstruction yi, Action fn)
		{
			yield return yi;
			fn.Invoke();
		}
	}
}