using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

	game_manager GMS;
	DoorScript d;
	// Use this for initialization
	void Awake(){
		GMS = GameObject.Find ("game_manager").GetComponent<game_manager> ();
		d = GameObject.Find ("Door").GetComponent<DoorScript> ();


	}
	void Start () {
		//d.GetComponent<DoorScript> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){
		

		Destroy (gameObject);
		d.yes =1;
		GMS.total_coins += 10;
		GameData.Coins = GMS.total_coins;
		GMS.UpdateUI ();

	}
}
