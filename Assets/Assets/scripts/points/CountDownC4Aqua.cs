using UnityEngine;
using System.Collections;

public class CountDownC4Aqua : MonoBehaviour {


	public static int timerInSecond42 = 0;
	private float levelTimer ;
	private bool updateTimer = false;
	// Use this for initialization
	void Start () {
		Debug.Log ("Time" +  PlayerPrefs.GetInt("Time In Second"));
		updateTimer = true;
		levelTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (updateTimer)  
			levelTimer += Time.deltaTime*1;

		timerInSecond42 =(int) Mathf.Round (levelTimer);
	}
	void LevelEnded()
	{
   		updateTimer = false;
 
   ///Save Time
  	 //PlayerPrefs.SetInt("Time In Second", timerInSecond );

		}
}
