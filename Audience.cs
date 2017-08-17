//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI


using UnityEngine;
using System.Collections;

public class Audience : MonoBehaviour {

	private string[] names = { "idle", "applause", "applause2", "celebration", "celebration2", "celebration3" };

	void Start ()
	{
		Animation[] AudienceMembers = gameObject.GetComponentsInChildren<Animation> ();
		foreach(Animation anim in AudienceMembers)
		{
			string thisAnimation = names [Random.Range (0,5)];

			anim.wrapMode = WrapMode.Loop;
			anim.GetComponent<Animation>().CrossFade (thisAnimation);
			anim [thisAnimation].time = Random.Range (0f, 3f);
		}
	}
}
