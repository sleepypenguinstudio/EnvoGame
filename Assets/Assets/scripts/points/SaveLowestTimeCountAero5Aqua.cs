using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero5Aqua : MonoBehaviour {
	
	//private CountDownC count4;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1ee", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC4Aqua.timerInSecond42 < PlayerPrefs.GetInt ("Time In Second Level 1ee"))
				PlayerPrefs.SetInt ("Time In Second Level 1ee", CountDownC4Aqua.timerInSecond42);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1ee")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC4Aqua.timerInSecond42 );
		
	}
}

