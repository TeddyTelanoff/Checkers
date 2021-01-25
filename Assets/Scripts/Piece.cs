using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : Square
{
	private bool[] m_AdjacentPieces;

    private void Awake()
    {
		PieceManager.Squares[m_Position.x, m_Position.y] = this;
		CheckAdjacentPieces();
	}

    private void OnDestroy()
	{
		PieceManager.Squares[m_Position.x, m_Position.y] = null;
	}

	private void CheckAdjacentPieces()
	{
		Square topLeft = new Square(), topRight = new Square(), botLeft = new Square(), botRight = new Square();
		if (m_Position.x > 0 && m_Position.y > 0)
			topLeft = PieceManager.Squares[m_Position.x - 1, m_Position.y - 1];
		if (m_Position.x < GameManager.BoardSpaces.x && m_Position.y > 0)
			topRight = PieceManager.Squares[m_Position.x + 1, m_Position.y - 1];
		if (m_Position.x > 0 && m_Position.y < GameManager.BoardSpaces.y - 1)
			botLeft = PieceManager.Squares[m_Position.x - 1, m_Position.y + 1];
		if (m_Position.x < GameManager.BoardSpaces.x && m_Position.y < GameManager.BoardSpaces.y - 1)
			botRight = PieceManager.Squares[m_Position.x + 1, m_Position.y + 1];
	}
}
