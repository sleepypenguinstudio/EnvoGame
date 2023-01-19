using UnityEngine;
using System.Collections;

public class TriggerForGettingO2 : MonoBehaviour {
	
	// Use this for initialization
	public GameObject Effect;
	public GameObject glass;
	//public int TotalOx = 0;
	

	
	// Update is called once per frame
	public void OnTriggerEnter(Collider other) {
		if (other.GetComponent<FirstPersonController>() == null)
			return;
		
		

		GetComponent<AudioSource>().Play ();
		glass.SetActive (false);
		Instantiate (Effect, transform.position, transform.rotation);
		gameObject.SetActive (false);
	}
}
