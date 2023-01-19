using UnityEngine;
using System.Collections;

public class HighScore1 : MonoBehaviour {

	public static int hiScore1 = 0 ;
	public GameObject StarHolder;
	// Use this for initialization
	void Start () {
	//PlayerPrefs.SetInt("HighScore1", 0);
		StaticFlag.TotalOx = 0;
		StarHolder.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore1")) {
			PlayerPrefs.SetInt("HighScore1", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore1 = (int)(PlayerPrefs.GetInt ("HighScore1"));
		Debug.Log ("L1" + hiScore1 +  "OX "  +StaticFlag.TotalOx);

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
