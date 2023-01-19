using UnityEngine;
using System.Collections;

public class HighScore2 : MonoBehaviour {

	public static int hiScore2 = 0 ;
	// Use this for initialization
	public GameObject StarHolder;
	void Start () {
		//PlayerPrefs.SetInt("HighScore2", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore2")) {
			PlayerPrefs.SetInt("HighScore2", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore2 = (int)(PlayerPrefs.GetInt ("HighScore2"));
		Debug.Log ("L3" + hiScore2);

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
