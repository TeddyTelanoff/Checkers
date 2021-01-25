using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
	public Vector2Int m_Position;
	public float m_Y;

	private Vector2 m_SquareOff;
	private Vector2 m_BlockSize;

	private void Start()
	{
		float blockSzX = (GameManager.End.x - GameManager.Start.x) / GameManager.BoardSpaces.x;
		float blockSzY = (GameManager.End.y - GameManager.Start.y) / GameManager.BoardSpaces.y;
		m_BlockSize = new Vector2(blockSzX, blockSzY);

		transform.localScale = new Vector3(m_BlockSize.x / 10, 1, m_BlockSize.y / 10);

		m_SquareOff = m_BlockSize / 2;
	}

	private void FixedUpdate()
	{
		float x = m_BlockSize.x * m_Position.x + GameManager.Start.x + m_SquareOff.x;
		float y = m_BlockSize.y * m_Position.y + GameManager.Start.y + m_SquareOff.y;

		transform.position = new Vector3(x, m_Y, y);
	}
}
