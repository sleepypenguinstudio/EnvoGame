using UnityEngine;
using System.Collections;

public class SpringSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
				//Debug.Log("sadas");
		
				if (other.gameObject.name == "Player") {
						Debug.Log ("sad");  
						GetComponent<AudioSource>().Play ();
						
				}
		}
}
