using UnityEngine;
using System.Collections;

public class triggerAnim : MonoBehaviour {
	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	public GameObject obj5;
	public AudioClip clip;
	public AudioSource audio;
	public	GameObject Myself;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other){

		audio.clip = clip;
		audio.Play();
		Myself.SetActive(false);

		obj1.GetComponent<Animator>().enabled=true;
		obj2.GetComponent<Animator>().enabled=true;
		obj3.GetComponent<Animator>().enabled=true;
		obj4.GetComponent<Animator>().enabled=true;
		obj5.GetComponent<Animator>().enabled=true;

	}
}
