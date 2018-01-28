using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMoneyChange : MonoBehaviour {
	public float speed = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			StartCoroutine (showMoneyChange ());
		}
	}

	IEnumerator showMoneyChange()
	{
		for (int i = 0; i < 50; i++) {
			transform.Translate (new Vector3 (-speed, 0, 0));
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.5f);
		for (int i = 0; i < 50; i++) {
			transform.Translate (new Vector3 (speed, 0, 0));
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.5f);
	}
}
