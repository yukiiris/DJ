using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadWords : MonoBehaviour {
	private string words;
	public bool ifend = false;
	// Use this for initialization
	void Start () {
		words = GetComponent<Text> ().text;
		StartCoroutine (lw ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator lw()
	{
		for (int j = 0; j < words.Length; j++)
		{
			GetComponent<Text> ().text = words.Substring (0, j + 1);
			yield return new WaitForSeconds (0.15f);
			}
		yield return new WaitForSeconds (0.5f);
		ifend = true;
		yield return new WaitForSeconds (0.5f);
	}

}
