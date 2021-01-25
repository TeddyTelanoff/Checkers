using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
	public static PieceManager Instance { get; private set; } = null;
	
	private Square[,] m_Squares;

	private void Awake()
	{
		Debug.Assert(Instance == null);
        Instance = this;

		m_Squares = new Square[GameManager.BoardSpaces.x, GameManager.BoardSpaces.y];
	}
}
