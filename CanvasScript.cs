using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {
	public Canvas canvasText1;
	// Use this for initialization
	void Start () {
		Invoke ("DisableText", 5f);
	}
	
	void DisableText()
	{
		canvasText1.enabled = false; 
	}
}
