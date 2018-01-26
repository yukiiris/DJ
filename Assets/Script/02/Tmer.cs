using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tmer : MonoBehaviour {

	public Text text;
	public int minute = 3;
	public int second1 = 10;
	public int second2 = 10;
	public int time = 180;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		if (time == 0)
		{

		}
	}

	IEnumerator f()
	{
		while (true)
		{
			if (time % 60 < 10)
			{
				text.text = time / 60 + ":" + 0 + "" + time % 60 + "";
			}
			else
			{
				text.text = time / 60 + ":" + time % 60;
			}
			time--;
			yield return new WaitForSeconds(1f);
		}
	}
}
