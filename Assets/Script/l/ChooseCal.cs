using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCal : MonoBehaviour {
	public GameObject manager;
	private ChooseManager cm;
	public GameObject rightChoice;
	public GameObject normalChoice;
	public GameObject thispage;
	// Use this for initialization
	void Start () {
		cm = manager.GetComponent<ChooseManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown(){

		if (cm.choice != null) {
			if (ifChooseRight () == 0) {
				print (0);
			} else if(ifChooseRight () == 1){
				print (1);
			}else if(ifChooseRight () == 2){
				print (2);
			}
			thispage.SetActive (false);
		}

	}

	int ifChooseRight(){
		if (cm.choice == rightChoice) {
			return(0);
		} else if (cm.choice == normalChoice) {
			return(1);
		} else{
			return(2);
		}
	}
}
