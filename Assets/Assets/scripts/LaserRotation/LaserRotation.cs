using UnityEngine;
using System.Collections;

public class LaserRotation : MonoBehaviour {

	public float rotateSpeed = .002f;
	private float speed = .0002f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed = .5f * rotateSpeed * Time.deltaTime;
		transform.Rotate (0,0, speed);
	}
}
