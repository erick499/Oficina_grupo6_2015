using UnityEngine;
using System.Collections;

public class Continue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Pause.stop == false){Destroy(gameObject);}

	}

	void OnMouseDown(){

		Pause.stop = false;

	}

}
