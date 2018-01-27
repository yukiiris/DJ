using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarConfirmer : MonoBehaviour {
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
		g.SetActive(false);
		gg.SetActive(false);
	}
}
