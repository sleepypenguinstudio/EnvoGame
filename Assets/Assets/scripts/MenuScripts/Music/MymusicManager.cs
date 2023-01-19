using UnityEngine;
using System.Collections;

public class MymusicManager : MonoBehaviour {


	public static float vol = 0.5f ;
	public Slider volumeSlider;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//audio.volume = volumeSlider.GetSliderPercent ();
		vol = volumeSlider.GetSliderPercent ();
		if (vol <= 0.03)
						vol = 0;
				else 
						vol = vol;
		Debug.Log (vol);
		GetComponent<AudioSource>().volume = vol;
	}
}
