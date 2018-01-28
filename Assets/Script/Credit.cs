using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour {

	public static int credit = 10;
	public static int left = 0;
	public static int mag = 10;
	public static int meal = 10;
	public static int warm = 10;
	public	Text text1;
	public Text text2;
	public Text text3;
	public Text text4;
	public Text text5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = "今日收入  " + credit;
		text2.text = "订阅杂志  " + mag;
		text3.text = "饮食       " + meal;
		text4.text = "暖气       " + warm;
		text5.text = "共计     " + (left + credit - mag - meal - warm);
	}
}
