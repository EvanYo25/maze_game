using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour {

	public int click = 0;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (click == 1) {
			//transform.Rotate (Vector3.left*10f);
			anim.SetTrigger("clickWall");
		}
	}
}
