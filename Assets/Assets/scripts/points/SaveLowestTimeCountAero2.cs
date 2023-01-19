using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero2 : MonoBehaviour {
	
	//private CountDownC count1;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1b", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC1.timerInSecond1 < PlayerPrefs.GetInt ("Time In Second Level 1b"))
				PlayerPrefs.SetInt ("Time In Second Level 1b", CountDownC1.timerInSecond1);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1b")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC1.timerInSecond1 );
		
	}
}

