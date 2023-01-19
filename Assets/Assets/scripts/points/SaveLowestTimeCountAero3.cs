using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero3 : MonoBehaviour {
	
	//private CountDownC count2;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1c", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC2.timerInSecond2 < PlayerPrefs.GetInt ("Time In Second Level 1c"))
				PlayerPrefs.SetInt ("Time In Second Level 1c", CountDownC2.timerInSecond2);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1c")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC2.timerInSecond2 );
		
	}
}

