﻿using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	public static int hiScore = 0 ;
	public GameObject StarHolder;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("HighScore", 0);
		StaticFlag.TotalOx = 0;
		StarHolder.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore")) {
			PlayerPrefs.SetInt("HighScore", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);

		}

		hiScore = (int)(PlayerPrefs.GetInt ("HighScore"));
		Debug.Log ("l" + hiScore);
		if (StaticFlag.TotalOx == 5) {
						multipleGravity.Flag = 1; 
						Time.timeScale = 0;
						StarHolder.SetActive (true);
				} 
		else{

			Time.timeScale = 1;			
			StarHolder.SetActive (false);
		}

	}
}
