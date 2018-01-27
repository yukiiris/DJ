using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDVD : MonoBehaviour {
	public GameObject[] g;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (DVDPlayer.c == null)
		{
			return;
		}
		DVDPlayer.c.GetComponent<Disk>().music.Stop();
		foreach (GameObject gg in g)
		{
			gg.SetActive(false);
		}
	}
}
