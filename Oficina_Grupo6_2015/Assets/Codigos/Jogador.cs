using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	int px = 1;

	void Update () {
		if (Pause.stop == false) {
			if (px < 3)
			if (Input.GetKeyDown ("d") || Input.GetKeyDown (KeyCode.RightArrow))
				px ++;
				
				
			if (px > 0)
			if (Input.GetKeyDown ("a") || Input.GetKeyDown (KeyCode.LeftArrow))
				px--;
				
				
			switch (px) {
					
			case 0:
					
				if (transform.localPosition.x >= -3.32f)
					transform.Translate (-0.5f, 0f, 0f);
				break;
					
			case 1:
					
				if (transform.localPosition.x >= -0.99f)
					transform.Translate (-0.5f, 0f, 0f);
					
				if (transform.localPosition.x < -0.99f)
					transform.Translate (0.5f, 0f, 0f);
				break;
					
			case 2:
					
				if (transform.localPosition.x >= 1.18f)
					transform.Translate (-0.5f, 0f, 0f);
					
				if (transform.localPosition.x < 1.18f)
					transform.Translate (0.5f, 0f, 0f);
				break;
					
			case 3:
					
				if (transform.localPosition.x < 3.63f)
					transform.Translate (0.5f, 0f, 0f);
				break;
					
			}
		}
				
		}
}
