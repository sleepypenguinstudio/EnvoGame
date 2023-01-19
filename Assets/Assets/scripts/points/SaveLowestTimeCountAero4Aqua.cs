using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero4Aqua : MonoBehaviour {
	
	//private CountDownC count3;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1de", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC3Aqua.timerInSecond32 < PlayerPrefs.GetInt ("Time In Second Level 1de"))
				PlayerPrefs.SetInt ("Time In Second Level 1de", CountDownC3Aqua.timerInSecond32);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1de")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC3Aqua.timerInSecond32 );
		
	}
}

