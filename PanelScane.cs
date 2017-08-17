using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PanelScane : MonoBehaviour {

	public AudioSource ButtonSound;
	public string namaScane;

	public void PindahScane(){
		AudioSource buttonSound = ButtonSound.GetComponent<AudioSource> ();
		buttonSound.PlayOneShot (buttonSound.clip);

		Scene sceneIni = SceneManager.GetActiveScene ();
		if (sceneIni.name != namaScane)
			SceneManager.LoadScene (namaScane);
	}
}