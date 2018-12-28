using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resulttext : MonoBehaviour {

	public Text result;
	private int total = GameData.Coins * 100;
	// Use this for initialization
	void Start () {
		
		result.text = "total scores: " + total.ToString () ;
	}
	

}
