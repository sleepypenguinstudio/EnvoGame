using UnityEngine;
using System.Collections;

public class HighScoreAqua : MonoBehaviour {

	public static int hiScore02 = 0 ;
	public GameObject StarHolder;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("HighScore02", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore02")) {
			PlayerPrefs.SetInt("HighScore02", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);

		}

		hiScore02 = (int)(PlayerPrefs.GetInt ("HighScore02"));
		Debug.Log ("l" + hiScore02);

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
