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