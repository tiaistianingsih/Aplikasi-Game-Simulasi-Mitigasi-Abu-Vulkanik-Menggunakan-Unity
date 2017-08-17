//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rst : MonoBehaviour {


	void Start ()
	{

	}

	void Update ()
	{
		ReloadLevel ();
	}

	void ReloadLevel()
	{
		if (Input.GetKey (KeyCode.R))
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}

}
