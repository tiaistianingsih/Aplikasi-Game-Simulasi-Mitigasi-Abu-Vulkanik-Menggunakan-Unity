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