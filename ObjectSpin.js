//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

#pragma strict

var spinx : int = 0;
var spiny : int = 0;
var spinz : int = 0;

function Update ()
{
	transform.Rotate(spinx, spiny, spinz);
	}
