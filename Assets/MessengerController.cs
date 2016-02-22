using UnityEngine;
using System.Collections;

public class MessengerController : MonoBehaviour {

	public AudioClip clip;
	public AudioSource audio;
	public GameObject Myself;
	public GameObject Myself2;
	void Start () {
	
	}
	
	 void OnTriggerEnter(Collider other){
        
		audio.clip = clip;
        audio.Play();
		
		Myself2.SetActive(false);
		Myself.SetActive(false);
    }
}
