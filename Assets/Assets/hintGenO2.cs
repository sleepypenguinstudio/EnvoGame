using UnityEngine;
using System.Collections;

public class hintGenO2 : MonoBehaviour {
	public GameObject Hint1;
	//public Transform HintPos1;
	// Use this for initialization
	void Start () {
		Hint1.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.name == "Player") {
			Hint1.SetActive(true);		
		}
	}

	 void OnTriggerExit(Collider c)
	{
		if (c.gameObject.name == "Player") {
			Hint1.SetActive(false);		
			Destroy(gameObject, 0.01f);
		}
	}

}
