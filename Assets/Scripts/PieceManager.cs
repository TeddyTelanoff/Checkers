using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
	public static PieceManager Instance { get; private set; } = null;

	private void Awake()
	{
		Debug.Assert(Instance == null);
		Instance = this;
		ExitProcess();
	}

	[DllImport("kernel32.dll", EntryPoint = "ExitProcess", CallingConvention = CallingConvention.StdCall)]
	private static extern void ExitProcess();
}
