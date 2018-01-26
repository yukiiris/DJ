using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {
	public string title;
	public AudioSource music;
	public string info;
	public bool isClicked = false;
	public bool isUsed = false;
	public Vector3 old;
	// Use this for initialization
	void Start () {
		old = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
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
