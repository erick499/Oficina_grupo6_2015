using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distancia : MonoBehaviour {

	public static Image distancia;
	
	void Start () {
		
		distancia = GetComponent<Image>();
		
	}
	
	
	void Update () {
		
		if (Pause.stop == false) {
			distancia.fillAmount -= 0.014f * Time.deltaTime;
		}
		if(distancia.fillAmount == 0)
		Application.LoadLevel("Ganhou");
	}
	
}
