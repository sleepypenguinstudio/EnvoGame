using UnityEngine;
using System.Collections;

public class MySFXManager : MonoBehaviour {


	public static float vol1 = 0.5f ;
	public SFXSlider volumeSlider;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//audio.volume = volumeSlider.GetSliderPercent ();
		vol1 = volumeSlider.GetSliderPercent ();
		if (vol1 <= 0.03)
						vol1 = 0;
				else 
						vol1 = vol1;
		Debug.Log (vol1);
		GetComponent<AudioSource>().volume = vol1;
	}
}
