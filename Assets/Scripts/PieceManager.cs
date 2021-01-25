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
		UnityEditor.EditorUtility.DisplayDialog("Error", "JK", "Haha so funny!");
	}
}
