using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyW : MonoBehaviour {
	public Waiter waiter;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		waiter.isClicked = true;
	}
}
