using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; } = null;
	public static Vector2 Start { get => Instance.m_Start; }
	public static Vector2 End { get => Instance.m_End; }
	public static Vector2 BoardSpaces { get => Instance.m_BoardSpaces; }

	public Vector2 m_Start;
	public Vector2 m_End;
	public Vector2Int m_BoardSpaces;

    private void Awake()
    {
		Debug.Assert(Instance == null);
		Instance = this;
    }
}
