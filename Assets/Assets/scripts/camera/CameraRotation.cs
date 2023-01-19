using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	public Transform playerTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(playerTarget.transform.rotation.x,playerTarget.transform.rotation.y,playerTarget.transform.rotation.z);
	}
}
