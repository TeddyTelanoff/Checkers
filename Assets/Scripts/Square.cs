using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
	public Vector2Int m_Position;

	private void FixedUpdate()
	{
		float x = GameManager.SquareSize.x * m_Position.x + GameManager.Start.x + GameManager.SquareSize.x / 2;
		float y = GameManager.SquareSize.y * m_Position.y + GameManager.Start.y + GameManager.SquareSize.y / 2;

		transform.position = new Vector3(x, transform.position.y, y);
	}
}
