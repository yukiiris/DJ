using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLineShowNext : MonoBehaviour {
	public GameObject next;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<LoadWords> ().ifend) {
			next.SetActive (true);
		}
	}
}
