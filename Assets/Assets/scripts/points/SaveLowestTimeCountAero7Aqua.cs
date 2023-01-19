using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero7Aqua : MonoBehaviour {
	
	//private CountDownC count6;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Time In Second Level 1ge", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC6Aqua.timerInSecond62 < PlayerPrefs.GetInt ("Time In Second Level 1ge"))
				PlayerPrefs.SetInt ("Time In Second Level 1ge", CountDownC6Aqua.timerInSecond62);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1ge")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC6Aqua.timerInSecond62);
		
	}
}

