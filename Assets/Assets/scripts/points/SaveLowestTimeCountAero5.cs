using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero5 : MonoBehaviour {
	
	//private CountDownC count4;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1e", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC4.timerInSecond4 < PlayerPrefs.GetInt ("Time In Second Level 1e"))
				PlayerPrefs.SetInt ("Time In Second Level 1e", CountDownC4.timerInSecond4);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1e")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC4.timerInSecond4 );
		
	}
}

