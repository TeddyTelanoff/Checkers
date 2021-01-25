using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : Square
{
	private volatile bool[] m_AdjacentPieces;

	private void FixedUpdate()
	{
		CheckAdjacentPieces();
	}

	private void CheckAdjacentPieces()
	{
		Square topLeft = null, topRight = null, botLeft = null, botRight = null;
		if (m_Position.x > 0 && m_Position.y > 0)
			topLeft = PieceManager.Squares[m_Position.x, m_Position.y];
		if (m_Position.x < GameManager.BoardSpaces.x && m_Position.y > 0)
			topRight = PieceManager.Squares[m_Position.x, m_Position.y];
		if (m_Position.x > 0 && m_Position.y < GameManager.BoardSpaces.y - 1)
			botLeft = PieceManager.Squares[m_Position.x, m_Position.y];
		if (m_Position.x < GameManager.BoardSpaces.x && m_Position.y < GameManager.BoardSpaces.y - 1)
			botRight = PieceManager.Squares[m_Position.x, m_Position.y];

		Debug.Log($"tl: {topLeft}, tr: {topRight}, bl: {botLeft}, br: {botRight}");
	}
}
