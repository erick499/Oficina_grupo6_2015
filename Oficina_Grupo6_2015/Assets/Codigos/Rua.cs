using UnityEngine;
using System.Collections;

public class Rua : MonoBehaviour {
	//float velo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Pause.stop == false) {
			transform.Translate(0f,-5f * Time.deltaTime, 0f);
			if(transform.localPosition.y <= -2203)
				transform.localPosition = new Vector3(4f,5366f,0f);

		}
	}
}
