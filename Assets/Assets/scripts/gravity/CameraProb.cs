﻿using UnityEngine;
using System.Collections;

public class CameraProb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0,0,180);
			//R = false;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			//transform.Rotate(0,0,180);
			//R = false;
		}
	}
}
