using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		gameObject.transform.GetChild(0).gameObject.SetActive(true);
	}
}
