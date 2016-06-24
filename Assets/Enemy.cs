using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public AudioSource burst;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	/*
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Bullet") {
			Destroy (other.gameObject);
			//burst.Play ();
		}
	}
*/
}
