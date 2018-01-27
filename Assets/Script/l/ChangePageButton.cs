using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePageButton : MonoBehaviour {
	private ChangePagesCon con;
	public int i = 1;
	// Use this for initialization
	void Start () {
		con = transform.parent.GetComponentInParent<ChangePagesCon> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		con.pages [con.page].SetActive (false);
		con.page += i;
		con.pages [con.page].SetActive (true);
	}
}
