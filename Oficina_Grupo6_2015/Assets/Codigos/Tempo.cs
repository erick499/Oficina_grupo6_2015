using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tempo : MonoBehaviour {

	public static Image tempo;
	
	void Start () {
		
		tempo = GetComponent<Image>();
		
	}
	
	
	void Update () {
		
		if(Pause.stop == false){
			tempo.fillAmount -= 0.01f * Time.deltaTime;
			
			if(tempo.fillAmount == 0)
				Application.LoadLevel("Perdeu");
		}
	}
	}
