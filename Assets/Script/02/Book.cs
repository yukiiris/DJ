using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour {

	public GameObject book;
    [Multiline(10)] public string info;
    [HideInInspector] public bool isClicked = false;
	[HideInInspector] public bool isUsed = false;
	[HideInInspector] public Vector3 old;
	// Use this for initialization
	void Start()
	{
		old = transform.position;
	}

	private void OnMouseDown()
	{
		isClicked = true;
	}

	private void OnMouseUp()
	{
		isClicked = false;
		if (!isUsed)
		{
			transform.position = old;
		}
	}
}
