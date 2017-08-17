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