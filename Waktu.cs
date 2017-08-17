using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waktu : MonoBehaviour {
	public Text timeText;
	public float timer = 120.00f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timeText.text = "" + timer.ToString ("00:00");
		if (timer <= 0) 
		{
			Time.timeScale = 0;
		}
	}
}

