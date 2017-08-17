//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using UnityEngine;
using System.Collections;

public class LoadAwal : MonoBehaviour {

	public GameObject pengaturanAwal;
	public GameObject backsound;

	void Awake(){
		if (PengaturanAwalTerus.obyek == null) {
			GameObject baruPengaturan = (GameObject)Instantiate (pengaturanAwal) as GameObject;
			baruPengaturan.name = pengaturanAwal.name;
		}

		if (BacksoundTerus.obyek == null) {
			GameObject baruBacksound = (GameObject)Instantiate (backsound) as GameObject;
			baruBacksound.name = backsound.name;
		}
	}
}
