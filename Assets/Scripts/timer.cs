using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
public class timer : MonoBehaviour {
	private float timer1 = 5.0f;
	public string nextScene; 	 	// Use this for initialization 	
	void Start () 
	{ 	

	} 	 	// Update is called once per frame 	
	void Update () 
	{ 	
		timer1 -= Time.deltaTime * 1; 
		if(timer1 <= 0.0f) 		
			Application.LoadLevel("CompleteScene"); 
	} 
}