using UnityEngine; 
using System.Collections; 
 

public class positon : MonoBehaviour { 
	 	
	private  Vector3 clickPosition; 
	private  GameObject changeTrigger;
	private GameObject special;
	 	// Use this for initialization 
		void Start () { 
		 	 
		 	} 

	 	// Update is called once per frame 
	 	void Update () {  
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();

			if (Physics.Raycast (ray, out hit)) {
				GameObject obj = hit.collider.gameObject;
				if (obj.gameObject.tag == "Special") {
					special = obj;
					//Destroy (obj.gameObject);
					Debug.Log (obj.name);
				}

				if (obj.gameObject.tag =="Panel" ) {
					Destroy (obj.gameObject);
					clickPosition = obj.transform.position;
				
					clickPosition.z = 0.0f;
					Instantiate (special, clickPosition, Quaternion.identity);

					Destroy (special.gameObject);
					Debug.Log (obj.name);
				}
			}
		}

	} 


 } 
