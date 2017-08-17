//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerButton : MonoBehaviour {

	float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//timer = Time.deltaTime + timer;
		timer += Time.deltaTime;
	}

	void ONGUI ()
	{
		if(timer <10) {
			GUI.Label (new Rect (100, 100, 200, 200), "Timer Count = " + timer);
		}	else {
			GUI.Label (new Rect (100, 100, 200, 200), "GAME OVER = ");
	}
	}
}
