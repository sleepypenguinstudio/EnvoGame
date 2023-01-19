using UnityEngine;
using System.Collections;

public class LevelComplete1d1 : MonoBehaviour {
	
	
	public GameObject star1a;
	public GameObject star2a;
	public GameObject star3a;
	//public GameObject StarHolder;
	
	
	public static int starNo = 0;
	
	//public static int starNum;
	// Use this for initialization
	void Start () {
		star1a.SetActive (false);
		star2a.SetActive (false);
		star3a.SetActive (false);
		starNo = 0;
		StaticFlag.TotalOx = 0;
		//StarHolder.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CountDownC3Aqua.timerInSecond32>500  && StaticFlag.TotalOx == 5) {
			starNo = 0;
		}
		else if (CountDownC3Aqua.timerInSecond32 <= 120 && StaticFlag.TotalOx == 5) {
			starNo = 3;
		}
		else if (CountDownC3Aqua.timerInSecond32 <= 180 && StaticFlag.TotalOx == 5) {
			starNo = 2;
		}
		else if (CountDownC3Aqua.timerInSecond32 < 500 && StaticFlag.TotalOx == 5)
			starNo = 1;
		
		
		if (starNo == 0) {
			//Time.timeScale = 0;
			star1a.SetActive (false);
			star2a.SetActive (false);
			star3a.SetActive (false);	
		}
		else if(starNo == 1)
		{
			
			star1a.SetActive(true);
			star2a.SetActive(false);
			star3a.SetActive(false);
		}
		else if(starNo == 2)
		{	
			//Time.timeScale = 0;
			star1a.SetActive(true);
			star2a.SetActive(true);
			star2a.SetActive(false);
		}
		else if(starNo == 3)
		{	
			//Time.timeScale = 0;
			star1a.SetActive(true);
			star2a.SetActive(true);
			star3a.SetActive(true);
		}
		Debug.Log (starNo); 
		
	}
	
	
}
