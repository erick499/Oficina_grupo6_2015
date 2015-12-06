using UnityEngine;
using System.Collections;

public class Recomecar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Pause.stop == false){Destroy(gameObject);}
		
	}
	
	void OnMouseDown(){
		Pause.stop = false;
		Application.LoadLevel (Application.loadedLevel);
		
	}
	
}