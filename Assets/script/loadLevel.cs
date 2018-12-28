using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadLevel : MonoBehaviour {


	public int LevelToLoad;

	// Use this for initialization
	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "player") {
			if (Application.loadedLevel == 5) {
				Application.LoadLevel (6);
			} else if (Application.loadedLevel == 1) {
				Application.LoadLevel (2);
			} else if (Application.loadedLevel == 2) {
				Application.LoadLevel (3);
			} else if (Application.loadedLevel == 3) {
				Application.LoadLevel (4);
			} else if (Application.loadedLevel == 4) {
				Application.LoadLevel (5);
			}
        }

	}

}
