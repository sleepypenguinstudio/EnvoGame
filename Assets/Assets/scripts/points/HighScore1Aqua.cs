using UnityEngine;
using System.Collections;

public class HighScore1Aqua : MonoBehaviour {

	public static int hiScore12 = 0 ;
	// Use this for initialization
	public GameObject StarHolder;
	void Start () {
		//PlayerPrefs.SetInt("HighScore1", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore12")) {
			PlayerPrefs.SetInt("HighScore12", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore12 = (int)(PlayerPrefs.GetInt ("HighScore12"));
		Debug.Log ("L1" + hiScore12 +  "OX "  +StaticFlag.TotalOx);


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
