using UnityEngine;
using System.Collections;

public class killedByLaser : MonoBehaviour {
	
	// Use this for initialization
	public GameObject player;
	//public GameObject glass;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Player>() == null)
			return;
		//Debug.Log("col");
		Destroy(player,.1f);

	}
}	