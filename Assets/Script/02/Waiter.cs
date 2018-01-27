using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiter : MonoBehaviour {
	public bool isClicked = false;
	public GameObject manager;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isClicked)
		{
			StartCoroutine(f());
			isClicked = false;
		}
	}

	IEnumerator f()
	{
		int i = 0;
		while (i < 8)
		{
			yield return new WaitForSeconds(1f);
			i++;
		}
		manager.GetComponent<Manager>().finishParty();
		manager.GetComponent<Manager>().startDVD();
	}
}
