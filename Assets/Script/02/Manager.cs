using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public GameObject introduction;
	public GameObject introductionT;
	public GameObject DVD;
	public GameObject playButton;
	public GameObject DVDPlayer;
	public GameObject DVDStop;
	public GameObject party;
	public GameObject broadcast;
	public GameObject broadcastT;
	public GameObject weather;
	public Tmer tmer;
	public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startIntroduction()
	{
		introduction.SetActive(true);
		introductionT.SetActive(true);
	}

	public void finishIntroduction()
	{
		introduction.SetActive(false);
		introductionT.SetActive(false);
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
		DVDStop.SetActive(true);
		playButton.SetActive(true);
		DVDPlayer.SetActive(true);
	}

	public void finishDVD()
	{
		DVD.SetActive(false);
		DVDStop.SetActive(false);
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

	public void check()
	{
		if (Time.hour == 2)
		{
			finishIntroduction();
			tmer.time = 180;
			text.text = "政党风向";
			startParty();
		}
		else if (Time.hour == 3)
		{
			finishParty();
			tmer.time = 180;
			text.text = "音乐之声";
			startDVD();
		}
		else if (Time.hour == 4)
		{
			finishDVD();
			tmer.time = 180;
			text.text = "心灵之约";
			startBroadcast();
		}
		else if (Time.hour == 5)
		{
			finishBroadcast();
			tmer.time = 180;
			text.text = "天气预报";
			startWeather();
		}
		else if (Time.hour == 6)
		{
			finishWeather();
		}
	}
}
