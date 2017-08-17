//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

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
