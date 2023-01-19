using UnityEngine;
using System.Collections;

public class HighScore6Aqua : MonoBehaviour {

	public static int hiScore62 = 0 ;
	public GameObject StarHolder;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("HighScore62", 0);
		StaticFlag.TotalOx = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((StaticFlag.TotalOx) > PlayerPrefs.GetInt ("HighScore62")) {
			PlayerPrefs.SetInt("HighScore62", (int)(StaticFlag.TotalOx));
			PlayerPrefs.SetInt("justMadeHighScore", 1);
			//flag = 1;
		}else{
			PlayerPrefs.SetInt("justMadeHighScore", 0);
		}

		hiScore62 = (int)(PlayerPrefs.GetInt ("HighScore62"));
		Debug.Log (hiScore62);

		

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
