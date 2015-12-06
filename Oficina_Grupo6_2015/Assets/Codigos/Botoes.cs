using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {

	}

	public void Sair(){Application.Quit();}

	public void Menu(){Application.LoadLevel ("Menu");}

	public void Jogo(){Application.LoadLevel ("Jogo"); Pause.stop = false;Obstaculos.pontos = 10000;}

	public void Tutorial(){Application.LoadLevel("Tutorial");}

	public void Creditos(){Application.LoadLevel("Creditos");}
}
