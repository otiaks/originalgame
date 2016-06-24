using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
public GameObject explosion;
	public AudioSource Bomb;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "bullet") {
			Destroy (this.gameObject);
			Instantiate (explosion, transform.position, Quaternion.identity);
			Bomb.Play ();
		}
	}


}
