using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

	game_manager GMS;
	bool clickover = true;
	clickMove c;
	void Awake(){
		GMS = GameObject.Find ("game_manager").GetComponent<game_manager> ();
		c = GameObject.Find ("moveWall").GetComponent<clickMove> ();


	}
	public void onPointerClick(){
		//print ("Click");
		if(clickover){
			c.click = 1;
			GMS.total_coins += 5;
			GameData.Coins = GMS.total_coins;
			clickover = false;
			GMS.UpdateUI ();
		}
		
	}
}
