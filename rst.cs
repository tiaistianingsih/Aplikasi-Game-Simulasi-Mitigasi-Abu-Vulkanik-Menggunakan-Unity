using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rst : MonoBehaviour {


	void Start ()
	{

	}

	void Update ()
	{
		ReloadLevel ();
	}

	void ReloadLevel()
	{
		if (Input.GetKey (KeyCode.R))
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}

}