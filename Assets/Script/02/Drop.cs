using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
	public GameObject g;
	public float i;
	public bool flag = false;
	public GameObject gg;
	public GameObject ggg;
	// Use this for initialization
	void Start () {
		g = gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flag)
		{
			StartCoroutine(f());
			flag = false;
		}
	}

	IEnumerator f()
	{
		print(111);
		while (Mathf.Abs(transform.position.y - i) > 0.1)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
			yield return new WaitForSeconds(0.01f);
		}
	}

	private void OnMouseDown()
	{
		gg.SetActive(true);
		ggg.SetActive(true);
	}
}
