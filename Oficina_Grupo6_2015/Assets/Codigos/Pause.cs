using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public static bool stop = false;
	public GameObject p,recomeçar,continuar,menu;
	void Start () {
		
	}
	
	void Update () { 
		if (Input.GetKeyDown ("p")) {
			if (stop == false) {
				stop = true;
				Instantiate (p, new Vector3 (0.01f, 0.01f, -6f), Quaternion.identity);
				Instantiate (recomeçar, new Vector3 (0.11f, -1.23f, -7f), Quaternion.identity);
				Instantiate (continuar, new Vector3 (0.11f, 0.18f, -7f), Quaternion.identity);
				Instantiate (menu, new Vector3 (0.11f, -2.62f, -7f), Quaternion.identity);
				
			} else
				
				stop = false;
			
		}
	}
}