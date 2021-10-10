using System;
using UnityEngine;

namespace Steamworks
{
	public static class CallbackDispatcher
	{
		public static void ExceptionHandler(Exception e)
		{
			Debug.LogException(e);
		}
	}
}
