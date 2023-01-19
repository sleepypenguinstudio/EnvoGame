using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero6 : MonoBehaviour {
	

	//private CountDownC count5;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1f", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC5.timerInSecond5 < PlayerPrefs.GetInt ("Time In Second Level 1f"))
				PlayerPrefs.SetInt ("Time In Second Level 1f", CountDownC5.timerInSecond5);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1f")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC5.timerInSecond5 );
		
	}
}

