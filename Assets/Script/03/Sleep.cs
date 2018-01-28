using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sleep : MonoBehaviour {
	public GameObject black;
	public GameObject blackT;
	public GameObject cover;
	public GameObject sleep;
	public AudioSource music;
	string word = "今天一天你做得很好。真理万岁！";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		black.SetActive(true);
		blackT.SetActive(true);
		cover.SetActive(false);
		sleep.SetActive(false);
		StartCoroutine(f());
	}

	IEnumerator f()
	{
		music.Play();
		for (int i = 0; i < word.Length; i++)
		{
			blackT.GetComponent<Text>().text = word.Substring(0, i + 1);
			yield return new WaitForSeconds(0.2f);
		}
		music.Stop();
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("01");
	}
}
