using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_behavior : MonoBehaviour {

	game_manager GMS;
	private float rotateSpeed = 10f;
	// Use this for initialization

	void Awake(){
		
		GMS = GameObject.Find ("game_manager").GetComponent<game_manager> ();
		GMS.cur_coins++;
	
	}
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left*rotateSpeed);


	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "player") {
			
			Destroy (gameObject);
			GMS.cur_coins--;
			GMS.total_coins++;
			GameData.Coins = GMS.total_coins;
			GMS.UpdateUI ();
		}
	}
}
