using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	// Use this for initialization
	public GameObject Effect;
	public int OxygenToAdd ;
	//public int TotalOx = 0;

	public void update()
	{
		OxygenToAdd = StaticFlag.TotalOx;
	}

	// Update is called once per frame
	public void OnTriggerEnter(Collider other) {
		if (other.GetComponent<FirstPersonController>() == null)
						return;


		StaticFlag.TotalOx += OxygenToAdd + 1;
		Debug.Log (StaticFlag.TotalOx);
		Instantiate (Effect, transform.position, transform.rotation);
		gameObject.SetActive (false);
	}
}
