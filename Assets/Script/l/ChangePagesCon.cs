using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePagesCon : MonoBehaviour {
	public GameObject[] pages;
	public int page = 0;

	void Start () {
		pages = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			pages [i] = transform.GetChild (i).gameObject;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
