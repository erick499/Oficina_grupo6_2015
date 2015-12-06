using UnityEngine;
using System.Collections;

public class Instancia : MonoBehaviour {

		public GameObject empty, boeiro, saco, arvore, poste, mendigo;
		float t, x, f, jamal;
		int random;
		
		public float maxTime = 2f;
		public float minTime = 1f;
		
		//current time
		private float time;
		
		//The time to spawn the object
		private float spawnTime;
		
		
		// Use this for initialization
		void Start () {
			//time = 5f;
			
			SetRandomTime();
			time = minTime;
		}
		
		public void turnEmptyTo(int value)
		{
			switch (value)
			{
			case 0:
				empty = boeiro;
				break;
				
			case 1:
				empty = saco;
				break;
				
			case 3:
				empty = mendigo;
				break;
				
			case 2:
				empty = arvore;
				break;
				
			case 4:
				empty = poste;
				break;
			}
		}
		
		// Update is called once per frame
		void Update () {
			
			if(Pause.stop == false){
					//time -= Time.deltaTime;
					if(maxTime >= minTime)
					maxTime -= 0.0005f;	

					if(minTime > 0.5)
					minTime -= 0.0009f;		


					f += 0.05f;
					
					t += 0.2f + f * Time.deltaTime;
					
					if (t >= 50) {
						t = 0;
						random = Random.Range (0, 4);
						
						switch (random) {
							
						case 0:
							turnEmptyTo(Random.Range(2,4));
							//turnEmptyTo(4);
							x = -3.32f;
							//print("coluna 1 || " + empty);
							break;
							
						case 1:
							turnEmptyTo(Random.Range(0,2));
							//turnEmptyTo(4);
							x = -0.99f;
							//print("coluna 2 || " + empty);
							break;
							
						case 2:
							turnEmptyTo(Random.Range(0,2));
							//turnEmptyTo(4);
							x = 1.18f;
							//print("coluna 3 || " + empty);
							break;
							
						case 3:
							turnEmptyTo(Random.Range(2,5));
							//turnEmptyTo(4);
							x = 3.63f;
							//print("coluna 4 || " + empty);
							break;				
						}
						
						
						
						//if (time <= 0f)
						//time = 5f;
						
						
			}
					}
			
		}
		
		void FixedUpdate(){
		if (Pause.stop == false) {
			//Counts up
			time += Time.deltaTime;
			
			//Check if its the right time to spawn the object
			if (time >= spawnTime) {
				SpawnObject ();
				SetRandomTime ();
			}
			
			/*
		do {
			minTime--;
			maxTime--;
		} while(minTime >= 1 && maxTime >= 1);
		*/
		}
	}
		
		
		//Spawns the object and resets the time
		void SpawnObject(){
			time = 0;
			Instantiate (empty, new Vector3 (x, 8f, 0f), Quaternion.identity);;
		}
		
		//Sets the random time between minTime and maxTime
		void SetRandomTime(){
			spawnTime = Random.Range(minTime, maxTime);
		}
	}
