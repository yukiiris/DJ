using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartOfTwo : MonoBehaviour {
	string[] words = { "真理党（先进真理共和党）", "尊敬的 81x号真理之子：", "您好！",
		"首先恭喜您通过考核得到了这个岗位。", "您要做的事情很简单，我们已经提前将所有发布内容制作完成，您只要在规定时间段选择节目播出即可。",
		"节目分为：", "今日政坛，时政要闻，真理箴言，每日音乐，荐书专栏，夜谈真理，天气预报。",
		"为了您和您的家人的生活，请努力工作，我们将通过每天的信誉点评价您的工作完成情况。",
		"追寻真理！维护真理！" };
	public Text text;
	// Use this for initialization
	void Start () {
		StartCoroutine(f());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator f()
	{
		for (int i = 0; i < words.Length; i++)
		{
			for (int j = 0; j < words[i].Length; j++)
			{
				text.text = words[i].Substring(0, j + 1);
				yield return new WaitForSeconds(0.15f);
			}
			yield return new WaitForSeconds(0.5f);
		}
		SceneManager.LoadScene("01");
	}
}
