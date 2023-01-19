using UnityEngine;
using System.Collections;

public class SaveLowestTimeCountAero1 : MonoBehaviour {

	//private CountDownC count;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("Time In Second Level 1a", 10000);
	}
	
	// Update is called once per frame
	void Update () {
		if (StaticFlag.TotalOx == 5) {
			if(CountDownC.timerInSecond < PlayerPrefs.GetInt ("Time In Second Level 1a"))
				PlayerPrefs.SetInt ("Time In Second Level 1a", CountDownC.timerInSecond);
		}
		Debug.Log ("Lowest Time =" + PlayerPrefs.GetInt ("Time In Second Level 1a")+ "\n");
		Debug.Log ("Taken Time =" + CountDownC.timerInSecond );
		
	}
}
