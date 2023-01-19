using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero3Aqua : MonoBehaviour {
	
	//private CountDownC count2;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1ce", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC2Aqua.timerInSecond22 < PlayerPrefs.GetInt ("Time In Second Level 1ce"))
				PlayerPrefs.SetInt ("Time In Second Level 1ce", CountDownC2Aqua.timerInSecond22);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1ce")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC2Aqua.timerInSecond22 );
		
	}
}

