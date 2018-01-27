using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyword : MonoBehaviour {
	public Text text;
	public static Text now;
	Color color;
	// Use this for initialization
	void Start () {
		color = text.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		print(111);
		if (now != null)
		{
			now.color = color;
		}
		text.color = Color.red;
		now = text;
	}
}
