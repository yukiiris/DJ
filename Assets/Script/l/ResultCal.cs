using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCal : MonoBehaviour {

	private GameObject show;
	public int num = 0;
	// Use this for initialization
	void Start () {

		show = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Credit.credit += num * 5;
		show.GetComponent<ShowMoneyChange> ().ifchange = true;
	}
}
