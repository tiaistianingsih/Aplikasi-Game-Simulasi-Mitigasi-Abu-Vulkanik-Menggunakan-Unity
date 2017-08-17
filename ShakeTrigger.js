//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

#pragma strict

private var camerashake : CameraShake;

function Start () 
{
	camerashake = GameObject.Find("Camera").GetComponent(CameraShake);
}

function OnTriggerEnter (Col : Collider)
{
	if(Col.tag == "Player")
	{
		camerashake.CameraShake();
		}
	}
