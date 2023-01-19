using UnityEngine;
using System.Collections;

public class menuEarthRotate : MonoBehaviour {
	
	//public float rotateSpeed = .25f;
	private float speed = .25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//speed = rotateSpeed;
		transform.Rotate (0,0,speed);
	}
}
