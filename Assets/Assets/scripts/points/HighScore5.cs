using UnityEngine;
using System.Collections;

public class HighScore5 : MonoBehaviour {

	public static int hiScore5 = 0 ;
	// Use this for initialization
	public GameObject StarHolder;
	void Start () {
		//PlayerPrefs.SetInt("HighScore5", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore5")) {
			PlayerPrefs.SetInt("HighScore5", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore5 = (int)(PlayerPrefs.GetInt ("HighScore5"));
		Debug.Log ("L5" + hiScore5);

		
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
