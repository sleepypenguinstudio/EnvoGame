using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero4 : MonoBehaviour {
	
	//private CountDownC count3;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Time In Second Level 1d", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC3.timerInSecond3 < PlayerPrefs.GetInt ("Time In Second Level 1d"))
				PlayerPrefs.SetInt ("Time In Second Level 1d", CountDownC3.timerInSecond3);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1d")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC3.timerInSecond3 );
		
	}
}

