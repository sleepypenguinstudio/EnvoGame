using UnityEngine;
using System.Collections;

public class HighScore4 : MonoBehaviour {

	public static int hiScore4 = 0 ;
	// Use this for initialization
	public GameObject StarHolder; 
	void Start () {
		//PlayerPrefs.SetInt("HighScore4", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore4")) {
			PlayerPrefs.SetInt("HighScore4", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore4 = (int)(PlayerPrefs.GetInt ("HighScore4"));
		Debug.Log (hiScore4);

		
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
