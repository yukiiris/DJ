using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string scene;
	public GameObject[] gameObjects;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		foreach (GameObject g in gameObjects)
		{
			g.SetActive(false);
		}
		SceneChanger.Change("01", "02");
	}
}
