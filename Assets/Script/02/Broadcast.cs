using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Broadcast : MonoBehaviour {
	public Text text;
	public Text text2;
	public Text text3;
	public string words;
	public int start;
	public int end;
	public static int i = 0;
	public bool isClicked = false;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator f()
	{
		string t = "";
		for (i = 0; i < words.Length; i++)
		{
			t += " ";
			text.text = words.Substring(0, i);
			if (i > 3)
			{
				text2.text = words.Substring(0, i - 3);
			}
			if (isClicked)
			{
				//text3.text = t + words.Substring(SilenceButton.start, SilenceButton.end);
			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}
