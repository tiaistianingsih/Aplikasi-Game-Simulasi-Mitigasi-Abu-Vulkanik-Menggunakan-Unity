//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscript : MonoBehaviour {

	public void restartgame()
	{
		SceneManager.LoadScene ("START GAME");
	}

	public void exitgame()
	{
		Debug.Log ("Exit Button pressed");
		Application.Quit ();
	}
}
