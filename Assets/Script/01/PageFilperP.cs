using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageFilperP : MonoBehaviour
{
	public Text title;
	public Text content;
	public string[] titles;
	public string[] contents;
	public PageFilperN p;
	int index;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		index = p.index;
	}

	private void OnMouseDown()
	{
		if (index > 1)
		{
			index--;
			p.index--;
			title.text = titles[index - 1];
			content.text = contents[index - 1];
		}
	}
}
