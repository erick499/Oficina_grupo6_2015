using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {
	public Text ponto;
	// Use this for initialization
	void Start () {
		ponto = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
		ponto.text = "" + Obstaculos.pontos;

	}
}
