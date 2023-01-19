using UnityEngine;
using System.Collections;

public class GuardLogic : MonoBehaviour {

	public Transform sightStart,sightEnd;
	public bool spotted ;  
	// Update is called once per frame
	void Update () {
		Raycasting ();
		Behaviours ();
	}
	void Raycasting() {
		Debug.DrawLine(sightStart.position,sightEnd.position, Color.green);
		spotted = Physics2D.Linecast (sightStart.position, sightEnd.position);
	}
	void Behaviours()
	{

	}
}
