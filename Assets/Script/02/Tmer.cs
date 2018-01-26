using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tmer : MonoBehaviour {

	public Text text;
	public int minute = 3;
	public int second1 = 0;
	public int second2 = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator f()
	{
		text.text = minute + "" + ":" + second1 + "" + second2;
		yield return new WaitForSeconds(1f);
		second2++;
		if (second2 == 10)
		{
			second2 = 0;
			second1++;
		}
		if (second1 == 10)
		{
			second1 = 0;
			minute--;
		}
		if (minute == -1)
		{
			//TODO
		}
	}
}
