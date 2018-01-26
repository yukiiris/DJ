using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOfTerminal : MonoBehaviour {
	public GameObject g;
	public GameObject cover;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		g.SetActive(true);
		cover.SetActive(true);
	}
}
