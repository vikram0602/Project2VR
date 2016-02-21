using UnityEngine;
using System.Collections;

public class transport : MonoBehaviour {
	public GameObject trans;

	public AudioClip myclip;
	public timer obj;
	// Update is called once per frame

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.T)) {
			
			trans.SetActive (true);
			this.gameObject.AddComponent<AudioSource> ();
			this.GetComponent<AudioSource> ().clip = myclip;
			this.GetComponent<AudioSource> ().Play ();
			//obj.enabled = true;
			this.GetComponent<timer>().enabled=true;


		}
	}




			
	
	}

