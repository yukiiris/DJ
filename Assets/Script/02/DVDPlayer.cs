using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVDPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		if (!other.transform.gameObject.GetComponent<Disk>().isClicked)
		{
			other.transform.position = new Vector3(10, 10, 0);
		}
	}
}
