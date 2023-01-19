using UnityEngine;
using System.Collections;

public class HighScore3 : MonoBehaviour {

	public static int hiScore3 = 0 ;
	// Use this for initialization

	public GameObject StarHolder;
	void Start () {
		//PlayerPrefs.SetInt("HighScore3", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore3")) {
			PlayerPrefs.SetInt("HighScore3", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore3 = (int)(PlayerPrefs.GetInt ("HighScore3"));

		Debug.Log ("L3" + hiScore3);
		
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
