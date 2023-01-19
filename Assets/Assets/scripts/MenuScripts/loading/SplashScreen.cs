using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public float Splashtime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Splashtime += Time.deltaTime;
		if (Splashtime > 2f)
						Application.LoadLevel (1);
	}
}
