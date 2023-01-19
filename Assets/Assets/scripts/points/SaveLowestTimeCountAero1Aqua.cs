using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero1Aqua : MonoBehaviour {

	//private CountDownC count;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1ae", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownCAqua.timerInSecond02 < PlayerPrefs.GetInt ("Time In Second Level 1ae"))
				PlayerPrefs.SetInt ("Time In Second Level 1ae", CountDownCAqua.timerInSecond02);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1ae")+ "\n");
		Debug.Log ("Taken Time =" + CountDownCAqua.timerInSecond02 );
		
	}
}
