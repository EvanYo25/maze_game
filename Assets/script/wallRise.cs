using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallRise : MonoBehaviour {

	Animator anim;
	public int yes=0;
	//public targetPosition=Vector3(3.62,1,1.14);
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {
		if (yes == 1) {
			anim.SetTrigger ("Step");
			//pauseEvent ();
		}
	}

	//void pauseEvent(){
	
	//	anim.enabled = false;
	//}
}
