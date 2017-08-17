//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PindahPanel : MonoBehaviour {

	public AudioSource buttonSound;
	public GameObject PanelAwal;
	public GameObject PanelTujuan;

	public void GantiKePanelBaru(){
		buttonSound.PlayOneShot (buttonSound.clip);
		PanelAwal.SetActive (false);
		PanelTujuan.SetActive (true);
	}
}
