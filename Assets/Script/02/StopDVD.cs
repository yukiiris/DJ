using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDVD : MonoBehaviour {
	public Manager manager;
	public AudioSource music;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		music.Play();
		if (DVDPlayer.c == null)
		{
			return;
		}
		DVDPlayer.c.GetComponent<Disk>().music.Stop();
		Time.hour++;
		StartCoroutine(manager.check());
	}
}
