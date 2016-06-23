using UnityEngine;
using System.Collections;


public class Shot : MonoBehaviour {
	public GameObject bullet; //GameObject型変数bulletを宣言
	public Transform spawn;   //Transform型変数spawnを宣言
	public float speed ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			shot(); 
		}

	}

	void shot(){
		GameObject obj = GameObject.Instantiate(bullet);
		obj.transform.position = spawn.position;
		obj.GetComponent<Rigidbody>().AddForce (-transform.up * speed);
		//obj.transform.position += -Vector3.up * speed * Time.deltaTime;

		Ray ray = new Ray(obj.transform.position, Vector3.down);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 200)){
			Debug.DrawLine (ray.origin, hit.point, Color.red);


			if (hit.collider.tag == "special") {
				//Vector3.zero;
				//Vector3 = new Vector3 (1, 1, 1);
				obj.GetComponent<Rigidbody>().AddForce (transform.forward * speed);
			}
		}
	}

}


