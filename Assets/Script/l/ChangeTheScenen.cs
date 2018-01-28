using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTheScenen : MonoBehaviour {
	public GameObject now;
	public GameObject next;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		next.SetActive (true);
		now.SetActive (false);
	}
}
