using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : Square
{
	public Color m_NormalColor;
	public Color m_OverColor;

	private void Awake()
	{
		GetComponent<MeshRenderer>().material.color = m_NormalColor;
		transform.localScale = new Vector3(GameManager.SquareSize.x / 10, 1, GameManager.SquareSize.y / 10);
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
