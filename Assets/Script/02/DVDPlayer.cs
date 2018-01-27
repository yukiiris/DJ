using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DVDPlayer : MonoBehaviour {
	public Text title;
	public Text content;
	public static bool isFull = false;
	public static Collider c;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		if (isFull)
		{
			return;
		}
		other.transform.gameObject.GetComponent<Disk>().isUsed = true;
		if (!other.transform.gameObject.GetComponent<Disk>().isClicked)
		{
			other.transform.position = new Vector3(10, 10, 0);
			title.text = other.transform.GetComponent<Disk>().title;
			content.text = other.transform.GetComponent<Disk>().info;
		}
		c = other;
	}

	private void OnTriggerExit(Collider other)
	{
		other.transform.gameObject.GetComponent<Disk>().isUsed = false;
	}

	public void play()
	{
		if (c == null)
		{
			return;
		}
		c.GetComponent<Disk>().music.Play();
	}
}
