using UnityEngine;
using System.Collections;

public class UnlockSubLevelAero : MonoBehaviour {


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
		Debug.Log (PlayerPrefs.GetInt ("HighScore1") + "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore2") + "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore3")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore4")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore5")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("HighScore"));

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("HighScore") == 5)
						SL2.SetActive (true);
		if (PlayerPrefs.GetInt ("HighScore1") == 5) {
						SL2.SetActive (true);	
						SL3.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore2") == 5) {
				
						SL2.SetActive (true);	
						SL3.SetActive (true);
						SL4.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore3") == 5) {
						SL2.SetActive (true);	
						SL3.SetActive (true);
						SL4.SetActive (true);			
						SL5.SetActive (true);
		}  if (PlayerPrefs.GetInt ("HighScore4") == 5) {
						SL2.SetActive (true);	
						SL3.SetActive (true);
						SL4.SetActive (true);			
						SL5.SetActive (true);			
						SL6.SetActive (true);
			} 
		if (PlayerPrefs.GetInt ("HighScore5") == 5) {

							
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
						SL6.SetActive (true);
						SL7.SetActive (true);
				}

		}
}
