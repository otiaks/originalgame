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
			//マウスが左クリックされた時
			shot(); //Shot関数を実行
		}
	}

	void shot(){
		GameObject obj = GameObject.Instantiate (bullet);
		obj.transform.position = spawn.position;
		obj.GetComponent<Rigidbody>().AddForce (-transform.up * speed);
	}



}


