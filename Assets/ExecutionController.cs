﻿using UnityEngine;
using System.Collections;

public class ExecutionController : MonoBehaviour {

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
        
    }
}
