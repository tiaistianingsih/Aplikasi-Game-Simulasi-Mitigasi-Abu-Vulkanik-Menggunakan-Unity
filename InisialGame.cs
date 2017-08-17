//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class InisialGame : MonoBehaviour {

	public static AudioSource UtamaSound;
	public static GameObject UtamaPanel;
	public static GameObject PetunjukPanel;
	public static GameObject PengaturanPanel;
	public static GameObject KeluarPanel;

	public AudioSource utamaSound;
	public GameObject utamaPanel;
	public GameObject petunjukPanel;
	public GameObject pengaturanPanel;
	public GameObject keluarPanel;

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		UtamaSound = utamaSound;
		UtamaPanel = utamaPanel;
		PetunjukPanel = petunjukPanel;
		PengaturanPanel = pengaturanPanel;
		KeluarPanel = keluarPanel;

	}
}
