using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shot : MonoBehaviour {
	public GameObject bullet; 
	public GameObject spawn;   
	public float speed ;
	public AudioSource gunSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void StartButton(){
		shot(); 
		gunSound.Play ();
	}
		
	void shot(){
		GameObject obj = GameObject.Instantiate(bullet);
		obj.transform.position = spawn.transform.position;
		obj.GetComponent<Rigidbody>().velocity = new Vector3 (1, 0, 0)*speed;
	}

}


