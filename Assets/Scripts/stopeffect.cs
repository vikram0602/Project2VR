using UnityEngine;
using System.Collections;

public class stopeffect : MonoBehaviour {
	private float timer1 = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer1 -= Time.deltaTime * 1; 
		if (timer1 <= 0.0f)
			this.gameObject.SetActive(false);
			//Application.LoadLevel("CompleteScene");
	
	}
}
