using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCal : MonoBehaviour {
	public GameObject manager;
	private ChooseManager cm;
	public GameObject rightChoice;
	public GameObject thispage;
	public GameObject nextpage;
	// Use this for initialization
	void Start () {
		cm = manager.GetComponent<ChooseManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown(){
		if (ifChooseRight()==0) {
			print (1);
		} else {
			print (2);
		}
		nextpage.SetActive (true);
		thispage.SetActive (false);
	}

	int ifChooseRight(){
		if (cm.choice == rightChoice) {
			return(0);
		} else
			return(1);
	}
}
