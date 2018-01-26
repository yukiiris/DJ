using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Broadcast : MonoBehaviour {
	public Text text;
	public Text text2;
	public string words;
	public int start;
	public int end;
	public static int i = 0;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator f()
	{
		string t = " ";
		for (i = 0; i < words.Length; i++)
		{
			text.text = words.Substring(0, i);
			if (i > 3)
			{
				text2.text = words.Substring(0, i - 3);
			}

			yield return new WaitForSeconds(0.5f);
		}
	}
}
