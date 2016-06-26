using UnityEngine;
using System.Collections;

public class ShotTitle : MonoBehaviour {
	public GameObject bullet; 
	public GameObject spawn;   
	public float speed ;
	public AudioSource gunSound;

	// Use this for initialization
	void Start () {
		
		//gunSound.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		shot ();
		//gunSound.Play ();
	}

	void shot(){
		GameObject obj = GameObject.Instantiate(bullet);

		obj.transform.position = spawn.transform.position;
			obj.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1)*speed;
			}
}