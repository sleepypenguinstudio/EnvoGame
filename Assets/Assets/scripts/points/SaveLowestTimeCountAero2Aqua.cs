using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero2Aqua : MonoBehaviour {
	
	//private CountDownC count1;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1be", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC1Aqua.timerInSecond12 < PlayerPrefs.GetInt ("Time In Second Level 1be"))
				PlayerPrefs.SetInt ("Time In Second Level 1be", CountDownC1Aqua.timerInSecond12);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1be")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC1Aqua.timerInSecond12 );
		
	}
}

