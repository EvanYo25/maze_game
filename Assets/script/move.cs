using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float rotateSpeed = 0.1f;
	float TranslateSpeed = 0.02f;
	float TranslateSpeedTime = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (Vector3.left*rotateSpeed);;	
		TranslateSpeedTime += 0.1f;

		transform.Translate(Vector3.up * TranslateSpeed);
		if (TranslateSpeedTime > 15.0f)
		{
			transform.Rotate(0, 0, 180);
			TranslateSpeedTime = 0.1f;
		}
	}

}
