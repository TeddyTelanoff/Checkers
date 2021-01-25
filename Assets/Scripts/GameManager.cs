using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; } = null;
	public static Vector2 Start { get => Instance.m_Start; }
	public static Vector2 End { get => Instance.m_End; }
	public static Vector2Int BoardSpaces { get => Instance.m_BoardSpaces; }
	public static Vector2 SquareSize { get => Instance.m_SquareSize; }

	public Vector2 m_Start;
	public Vector2 m_End;
	public Vector2Int m_BoardSpaces;

	private Vector2 m_SquareSize;

	private void Awake()
	{
		Debug.Assert(Instance == null);
		Instance = this;

		float blockSzX = (m_End.x - m_Start.x) / m_BoardSpaces.x;
		float blockSzY = (m_End.y - m_Start.y) / m_BoardSpaces.y;
		m_SquareSize = new Vector2(blockSzX, blockSzY);
	}
}
