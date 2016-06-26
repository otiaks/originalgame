using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public GameObject bullet;
	public float speed;
	public AudioSource Bomb;
	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame

	void Update () {
		 Ray raydown = new Ray (transform.position, Vector3.down);
		 RaycastHit hitdown;

		if (Physics.Raycast (raydown, out hitdown, 200)) {
			Debug.DrawLine (raydown.origin, hitdown.point, Color.red);

			if (hitdown.collider.tag == "Panel") {
				GetComponent<Rigidbody> ().velocity = new Vector3 (1, 0, 0) * speed;
			} else if (hitdown.collider.tag == "Special") {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 1) * speed;
			}
		}
	}
		

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Enemy") {
			Bomb.Play ();
		}
	}

}