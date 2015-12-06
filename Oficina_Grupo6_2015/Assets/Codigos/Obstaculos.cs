using UnityEngine;
using System.Collections;

public class Obstaculos : MonoBehaviour {
	public static int pontos = 10000;
	public static float p;
	private GameObject Obstaculo;
	//public static bool parar = false;
	public static float vel;
	
	// Use this for initialization
	void Start () 
	{
		Obstaculo = GameObject.Find ("Obstaculo");
	}
	
	// Update is called once per frame
	void Update () {
		if(Pause.stop == false){
			vel = -5f * Time.deltaTime;
			
			p = transform.localPosition.y;
			
			transform.Translate (0f, vel, 0f);
			
			if (p <= -10) { 
				Destroy (gameObject);
			}

		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		
		if (coll.gameObject.tag == "Player")
		{
			pontos -= 7;
			Tempo.tempo.fillAmount -= 0.03f;
			Destroy (gameObject);
		}
	}
	
}
