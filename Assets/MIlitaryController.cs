using UnityEngine;
using System.Collections;

public class MIlitaryController : MonoBehaviour {

	public AudioClip clip;
	public AudioSource audio;
	public GameObject Myself;
	public GameObject Myself2;
	public GameObject Myself3;
	public GameObject obj1;
	public GameObject obj2;

	// Use this for initialization
	void Start () {
	
	}
	
	 void OnTriggerEnter(Collider other){
        
		audio.clip = clip;
        audio.Play();
		obj1.GetComponent<AudioSource> ().enabled = true;
		
		Myself2.SetActive(false);
		Myself3.SetActive(false);
		Myself.SetActive(false);
		//obj1.GetComponent<Animator>().enabled=false;
		obj1.GetComponent<Animator>().enabled=true;
		obj2.GetComponent<Animator>().enabled=true;
    }
}
