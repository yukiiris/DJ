using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHead : MonoBehaviour {
	private ResultCal rc;
	public GameObject right;
	// Use this for initialization
	void Start () {
		rc = GetComponent<ResultCal> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (right.activeInHierarchy)
			rc.num = 2;
		else
			rc.num = -1;
	}
}
