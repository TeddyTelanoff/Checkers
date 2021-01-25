using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
	public Vector2 m_Start;
	public Vector2 m_End;
	public Vector2Int m_Position;
	public Vector2Int m_Board;
	public float m_Y;

	private Vector2 m_SquareOff;
	private Vector2 m_BlockSize;

	private void Start()
	{
		float blockSzX = (m_End.x - m_Start.x) / m_Board.x;
		float blockSzY = (m_End.y - m_Start.y) / m_Board.y;
		m_BlockSize = new Vector2(blockSzX, blockSzY);

		transform.localScale = new Vector3(m_BlockSize.x / 10, 1, m_BlockSize.y / 10);

		m_SquareOff = m_BlockSize / 2;
	}

	private void FixedUpdate()
	{
		float x = m_BlockSize.x * m_Position.x + m_Start.x + m_SquareOff.x;
		float y = m_BlockSize.y * m_Position.y + m_Start.y + m_SquareOff.y;

		transform.position = new Vector3(x, m_Y, y);
	}
}
