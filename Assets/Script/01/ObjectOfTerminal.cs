﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOfTerminal : MonoBehaviour {
	public GameObject[] g;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		foreach (GameObject gg in g)
		{
			gg.SetActive(true);
		}
	}
}
