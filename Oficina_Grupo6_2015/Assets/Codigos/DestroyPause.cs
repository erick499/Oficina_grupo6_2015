using UnityEngine;
using System.Collections;

public class DestroyPause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Pause.stop == false)
			Destroy (gameObject);

	}
}
