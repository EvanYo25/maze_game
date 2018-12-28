using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOn1 : MonoBehaviour {

	wallRise w;
	game_manager GMS;
	bool step = true;
	public int yes=0;
	void Awake(){
		GMS = GameObject.Find ("game_manager").GetComponent<game_manager> ();
		w = GameObject.Find ("trigger1").GetComponent<wallRise> ();


	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other){


		//Destroy (gameObject);
		if(step){
			w.yes =1;
			GMS.total_coins += 5;
			GameData.Coins = GMS.total_coins;
			step = false;
			GMS.UpdateUI ();
		}

	}
}
