using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
	public GameObject next;
	// Use this for initialization
	void Start () {
		StartCoroutine (startgame ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator startgame(){
		yield return new WaitForSeconds (1f);
		if (next != null) {
			next.SetActive (true);
		}
		gameObject.SetActive (false);
		yield return new WaitForSeconds (0.1f);
	}
}
