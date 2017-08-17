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
