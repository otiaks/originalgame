using UnityEngine;
using System.Collections;

public class Shot: MonoBehaviour {

	public GameObject Bullet;
	GameObject bulletclone;

	public Transform tip;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Shoot();
		}
	}

	void Shoot(){
		bulletclone = GameObject.Instantiate (Bullet, tip.position, tip.rotation)as GameObject;
		bulletclone.GetComponent<Rigidbody>().AddForce(tip.forward*speed);
	}
}
