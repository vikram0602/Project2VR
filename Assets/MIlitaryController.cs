using UnityEngine;
using System.Collections;

public class MIlitaryController : MonoBehaviour {

	public AudioClip clip;
	public AudioSource audio;
	public GameObject Myself;
	public GameObject Myself2;
	public GameObject Myself3;
	// Use this for initialization
	void Start () {
	
	}
	
	 void OnTriggerEnter(Collider other){
        
		audio.clip = clip;
        audio.Play();
		
		Myself2.SetActive(false);
		Myself3.SetActive(false);
		Myself.SetActive(false);
    }
}
