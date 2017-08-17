//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class KeluarGame : MonoBehaviour {

	public AudioSource ButtonSound;

	public void KeluarDariGame(){
		AudioSource buttonSound = ButtonSound.GetComponent<AudioSource> ();
		buttonSound.PlayOneShot (buttonSound.clip);
		Application.Quit ();
	}
}
