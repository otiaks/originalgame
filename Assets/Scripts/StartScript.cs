using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	public AudioSource selct;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void startgame(){
		selct.Play ();
		Application.LoadLevel ("main");
		//FadeManager.Instance.LoadLevel("Scene2",1.0f);
	}

}
