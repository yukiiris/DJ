using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton : MonoBehaviour {
	public GameObject g;
	public GameObject gg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		gg.SetActive(false);
		g.SetActive(false);
	}
}
