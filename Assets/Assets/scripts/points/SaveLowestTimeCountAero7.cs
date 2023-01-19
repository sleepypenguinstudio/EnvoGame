using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero7 : MonoBehaviour {
	
	//private CountDownC count6;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1g", 1000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC6.timerInSecond6 < PlayerPrefs.GetInt ("Time In Second Level 1g"))
				PlayerPrefs.SetInt ("Time In Second Level 1g", CountDownC6.timerInSecond6);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1g")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC6.timerInSecond6);
		
	}
}

