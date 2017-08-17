//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

#pragma strict

var coinSound : AudioClip;

function OnTriggerEnter (other : Collider)
{
	if(other.tag == "Player")
	{
	AudioSource.PlayClipAtPoint(coinSound, transform.position);
	Destroy(gameObject);
	GetComponent.<AudioSource>().PlayOneShot (coinSound);

	}
}
