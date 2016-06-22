using UnityEngine;
using System.Collections;

public class Check : MonoBehaviour {
	float speed = 200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void onTriggerEnter (Collider other){
		if(other.tag=="check"){
			other.GetComponent<Rigidbody>().AddForce (transform.up * speed);
		}
	}
}
