using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	//public float initMusic = 0.5f;
	// Use this for initialization
	void Start () {
		//audio.volume = MymusicManager.vol;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(MymusicManager.vol);

		GetComponent<AudioSource>().volume = MymusicManager.vol;
		Slider.initialSliderPercent = MymusicManager.vol;
		Debug.Log ("music" + MymusicManager.vol);
	}
}
