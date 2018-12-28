using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game_manager : MonoBehaviour {

	public int cur_coins=0;
	public Text coinCollect;
	public int max_coins=0;
	public int total_coins;

	public GameObject exit;
	// Use this for initialization
	void Start () {
		//exit.SetActive (false);
		total_coins = GameData.Coins;
		max_coins = cur_coins;
		UpdateUI ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateUI(){

		if (cur_coins >= 0) {
			coinCollect.text = "coins collected: " + (max_coins - cur_coins).ToString () + "/" + max_coins.ToString () + "\ntotal score: " + total_coins*100; 
		} //else if (cur_coins <= 0) {
			//coinCollect.text = "Find the door";
			//exit.SetActive (true);

		//}
	}

}

