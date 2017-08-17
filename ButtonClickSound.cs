//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClickSound : MonoBehaviour {

	public AudioClip sound;
	private Button button { get { return GetComponent<Button> (); } }
	private AudioSource source { get { return GetComponent<AudioSource> (); } }
	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;

		button.onClick.AddListener (() => PlaySound ());
	}
	
	void PlaySound(){
		source.PlayOneShot (sound);
	}
}
