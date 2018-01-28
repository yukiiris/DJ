using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiter : MonoBehaviour {
	public bool isClicked = false;
	public Manager manager;
	public int waitTime;
	
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
		while (i < waitTime)
		{
			yield return new WaitForSeconds(1f);
			i++;
		}
		Time.hour++;
		manager.check();
	}
}
