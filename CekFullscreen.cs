//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CekFullscreen : MonoBehaviour {

	void Awake(){

		Toggle toggleFullscreen = this.gameObject.GetComponent<Toggle> ();

		if(BacksoundFullscreen.FullscreenStatus == true){
			toggleFullscreen.isOn = true;
		}else{
			toggleFullscreen.isOn = false;
		}

		if (toggleFullscreen.isOn == true) {
			Screen.fullScreen = true;
			BacksoundFullscreen.FullscreenStatus = true;
		} else {
			Screen.fullScreen = false;
			BacksoundFullscreen.FullscreenStatus = false;
		}
	}

	public void FullscreenOnOff(){
		
		if(Screen.fullScreen == true){
			Screen.fullScreen = false;
			BacksoundFullscreen.FullscreenStatus = false;
			Debug.Log ("Fullscreen : " +BacksoundFullscreen.FullscreenStatus);
		}else{
			Screen.fullScreen = true;
			BacksoundFullscreen.FullscreenStatus = true;
			Debug.Log ("Fullscreen : " +BacksoundFullscreen.FullscreenStatus);
		}
	}
}
