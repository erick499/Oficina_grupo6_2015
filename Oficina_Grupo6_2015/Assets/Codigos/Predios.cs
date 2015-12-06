using UnityEngine;
using System.Collections;

public class Predios : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Pause.stop == false) {
			transform.Translate(0f,-5f * Time.deltaTime, 0f);
			if(transform.localPosition.y <= -2210)
				transform.localPosition = new Vector3(4f,5050f,-1f);
			
		}
	}
}