using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero6Aqua : MonoBehaviour {
	

	//private CountDownC count5;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1fe", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC5Aqua.timerInSecond52 < PlayerPrefs.GetInt ("Time In Second Level 1fe"))
				PlayerPrefs.SetInt ("Time In Second Level 1fe", CountDownC5Aqua.timerInSecond52);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1fe")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC5Aqua.timerInSecond52 );
		
	}
}

