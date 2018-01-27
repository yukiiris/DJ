using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookPlayer : MonoBehaviour {

	public Text title;
	public Text content;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerStay(Collider other)
	{
		other.transform.gameObject.GetComponent<Book>().isUsed = true;
		if (!other.transform.gameObject.GetComponent<Book>().isClicked)
		{
			other.transform.position = new Vector3(10, 10, 0);
			title.text = other.transform.GetComponent<Book>().title;
			content.text = other.transform.GetComponent<Book>().info;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		other.transform.gameObject.GetComponent<Book>().isUsed = false;
	}
}
