//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene1 : MonoBehaviour {

	float timer = 140.0f;

	void Update (){
		timer -= Time.deltaTime;

		if(timer <= 0)
		{
			Application.LoadLevel ("GAME OVER");
		}
	}
}
