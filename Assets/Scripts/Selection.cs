using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
	public Color m_NormalColor;
	public Color m_OverColor;

	public Vector2Int m_Position;
	public float m_Y;

	private Vector2 m_SquareOff;

	private void Awake()
	{
		GetComponent<MeshRenderer>().material.color = m_NormalColor;
		transform.localScale = new Vector3(GameManager.SquareSize.x / 10, 1, GameManager.SquareSize.y / 10);

		m_SquareOff = GameManager.SquareSize / 2;
	}

	private void FixedUpdate()
	{
		float x = GameManager.SquareSize.x * m_Position.x + GameManager.Start.x + m_SquareOff.x;
		float y = GameManager.SquareSize.y * m_Position.y + GameManager.Start.y + m_SquareOff.y;

		transform.position = new Vector3(x, m_Y, y);
	}

	private void OnMouseEnter()
	{
		GetComponent<MeshRenderer>().material.color = m_OverColor;
	}

	private void OnMouseExit()
	{
		GetComponent<MeshRenderer>().material.color = m_NormalColor;
	}
}
