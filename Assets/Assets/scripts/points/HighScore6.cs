using UnityEngine;
using System.Collections;

public class HighScore6 : MonoBehaviour {

	public static int hiScore6 = 0 ;
	// Use this for initialization
	public GameObject StarHolder ;

	void Start () {
		//PlayerPrefs.SetInt("HighScore6", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore6")) {
			PlayerPrefs.SetInt("HighScore6", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore6 = (int)(PlayerPrefs.GetInt ("HighScore6"));
		Debug.Log (hiScore6);

		
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
