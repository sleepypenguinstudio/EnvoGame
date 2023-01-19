using UnityEngine;
using System.Collections;

public class HighScore5Aqua : MonoBehaviour {

	public static int hiScore52 = 0 ;
	// Use this for initialization
	public GameObject StarHolder;

	void Start () {
		//PlayerPrefs.SetInt("HighScore52", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore52")) {
			PlayerPrefs.SetInt("HighScore52", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore52 = (int)(PlayerPrefs.GetInt ("HighScore52"));
		Debug.Log ("L5" + hiScore52);

		

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
