//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
	public Transform canvas;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Pause ();
		}		
	}
	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
		} 
		else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}
}
