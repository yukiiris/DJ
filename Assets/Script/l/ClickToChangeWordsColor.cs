using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToChangeWordsColor : MonoBehaviour {
	private Color oricolor;
	public Color newcolor;
	private ChooseManager cm;
	public GameObject manager;
	// Use this for initialization
	void Start () {
		oricolor = GetComponent<Text> ().color;
		cm = manager.GetComponent<ChooseManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		ChangeColor ();
	}

	void ChangeColor(){
		if (cm.choice != null) {
			cm.choice.GetComponent<ClickToChangeWordsColor> ().ReColor ();
		}
		cm.choice = gameObject;
		GetComponent<Text> ().color = newcolor;
	}

	void ReColor(){
		GetComponent<Text> ().color = oricolor;
	}
}
