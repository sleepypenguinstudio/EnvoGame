using UnityEngine;
using System.Collections;

public class SFXController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(MymusicManager.vol);
		GetComponent<AudioSource>().volume = MySFXManager.vol1;
		SFXSlider.initialSliderPercent = MySFXManager.vol1;
	}
}
