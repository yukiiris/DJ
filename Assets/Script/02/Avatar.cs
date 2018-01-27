using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour {
	public GameObject g;
	public static GameObject gg = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		print(111);
		if (gg != null)
			gg.SetActive(false);
		g.SetActive(true);
		gg = g;
	}
}
