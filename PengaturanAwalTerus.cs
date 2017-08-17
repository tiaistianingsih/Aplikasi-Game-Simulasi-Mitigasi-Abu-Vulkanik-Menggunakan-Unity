//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PengaturanAwalTerus : MonoBehaviour {
	public static PengaturanAwalTerus obyek = null;

	void Awake(){
		if (obyek == null)
			obyek = this;
		else if (obyek != null)
			Destroy (gameObject);

		DontDestroyOnLoad (this.gameObject);
	}
}
