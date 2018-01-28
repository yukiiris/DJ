using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookConfirmer : MonoBehaviour {
	public Manager manager;
	public BookPlayer player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		Time.hour++;
		StartCoroutine (manager.check ());
		player.confirm.SetActive(false);
		player.confirmT.SetActive(false);
		player.c.SetActive(false);
	}
}
