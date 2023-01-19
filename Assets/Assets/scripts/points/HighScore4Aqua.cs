using UnityEngine;
using System.Collections;

public class HighScore4Aqua : MonoBehaviour {

	public static int hiScore42 = 0 ;
	public GameObject StarHolder;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("HighScore42", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore42")) {
			PlayerPrefs.SetInt("HighScore42", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore42 = (int)(PlayerPrefs.GetInt ("HighScore42"));
		Debug.Log (hiScore42);

		

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
