using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilenceButton : MonoBehaviour {
	public AudioSource music;
	public static int start = 0;
	public static int end = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		music.Play();
		start = Broadcast.i;
	}

	private void OnMouseUp()
	{
		music.Stop();
		end = Broadcast.i;
	}

	public static int check()
	{
		return end - start;
	}
}
