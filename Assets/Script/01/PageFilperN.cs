using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageFilperN : MonoBehaviour {
	public Text title;
	public Text content;
	public string[] titles;
	public string[] contents;
	public int index = 1;

	// Use this for initialization
	void Start () {
		title.text = titles[index - 1];
		content.text = contents[index - 1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (index < titles.Length)
		{
			index++;
			title.text = titles[index - 1];
			content.text = contents[index - 1];
		}
	}
}
