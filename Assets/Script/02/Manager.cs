using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public GameObject DVD;
	public GameObject playButton;
	public GameObject DVDPlayer;
	public GameObject party;
	public GameObject broadcast;
	public GameObject broadcastT;
	public GameObject weather;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startParty()
	{
		party.SetActive(true);
	}

	public void finishParty()
	{
		party.SetActive(false);
	}

	public void startDVD()
	{
		DVD.SetActive(true);
		playButton.SetActive(true);
		DVDPlayer.SetActive(true);
	}

	public void finishDVD()
	{
		DVD.SetActive(false);
		playButton.SetActive(false);
		DVDPlayer.SetActive(false);
	}

	public void startBroadcast()
	{
		broadcast.SetActive(true);
		broadcastT.SetActive(true);
	}

	public void finishBroadcast()
	{
		broadcast.SetActive(false);
		broadcastT.SetActive(false);
	}

	public void startWeather()
	{
		weather.SetActive(true);
	}

	public void finishWeather()
	{
		weather.SetActive(false);
	}
}
