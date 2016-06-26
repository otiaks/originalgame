using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void startgame(){
		Application.LoadLevel ("main");
		//FadeManager.Instance.LoadLevel("Scene2",1.0f);
	}

}
