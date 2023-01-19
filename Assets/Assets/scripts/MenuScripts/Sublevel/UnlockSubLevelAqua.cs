using UnityEngine;
using System.Collections;

public class UnlockSubLevelAqua : MonoBehaviour {
	
	
	public GameObject SL1;
	public GameObject SL2;
	public GameObject SL3;
	public GameObject SL4;
	public GameObject SL5;
	public GameObject SL6;
	public GameObject SL7;
	
	
	// Use this for initialization
	
	void Start () {
		SL1.SetActive (true);
		SL2.SetActive (false);
		SL3.SetActive (false);
		SL4.SetActive (false);
		SL5.SetActive (false);
		SL6.SetActive (false);
		SL7.SetActive (false);
		Debug.Log (PlayerPrefs.GetInt ("HighScore12") + "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore22") + "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore32")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore42")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore52")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore02"));
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("HighScore02") == 5)
			SL2.SetActive (true);
		if (PlayerPrefs.GetInt ("HighScore12") == 5) {
			SL2.SetActive (true);	
			SL3.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore22") == 5) {
			
			SL2.SetActive (true);	
			SL3.SetActive (true);
			SL4.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore32") == 5) {
			SL2.SetActive (true);	
			SL3.SetActive (true);
			SL4.SetActive (true);			
			SL5.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore42") == 5) {
			SL2.SetActive (true);	
			SL3.SetActive (true);
			SL4.SetActive (true);			
			SL5.SetActive (true);			
			SL6.SetActive (true);
		} 
		if (PlayerPrefs.GetInt ("HighScore52") == 5) {
			
			
			SL2.SetActive (true);
			SL3.SetActive (true);			
			SL4.SetActive (true);			
			SL5.SetActive (true);
			SL6.SetActive (true);
			SL7.SetActive (true);
		}
		
	}
}
