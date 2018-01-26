using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DVDPlayer : MonoBehaviour {
	public Text title;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		other.transform.gameObject.GetComponent<Disk>().isUsed = true;
		if (!other.transform.gameObject.GetComponent<Disk>().isClicked)
		{
			other.transform.position = new Vector3(10, 10, 0);
			title.text = other.transform.GetComponent<Disk>().title;

		}
	}

	private void OnTriggerExit(Collider other)
	{
		other.transform.gameObject.GetComponent<Disk>().isUsed = false;
	}
}
