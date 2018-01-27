using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWeather : MonoBehaviour {
	public GameObject manager;
	private ChooseManager cm;
	public GameObject[] choice;
	public GameObject[] weather;
	// Use this for initialization
	void Start () {
		cm = manager.GetComponent<ChooseManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		int i = 0;
		while(i < choice.Length&&cm.choice!=choice[i]) {
				i++;
		}
		weather [i].SetActive (true);
	}
}
