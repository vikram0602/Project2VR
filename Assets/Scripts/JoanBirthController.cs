using UnityEngine;
using System.Collections;

public class JoanBirthController : MonoBehaviour {

	public AudioSource audio;
	public GameObject myself;
	public AudioClip clip;
	
	// Use this for initialization
	void Start () {
	
	}
	
	//void OnCollisionEnter(Collision collision) {
	void OnTriggerEnter(Collider other){
        
		audio.clip = clip;
        audio.Play();
		myself.SetActive(false);
        
    }
}
