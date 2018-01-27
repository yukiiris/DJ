using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRemote : MonoBehaviour {
	public GameObject chi;
	public GameObject par;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (par.activeInHierarchy&&!chi.activeInHierarchy) {
			chi.SetActive (true);
		}
		if (!par.activeInHierarchy&&chi.activeInHierarchy) {
			chi.SetActive (false);
		}
	}
}
