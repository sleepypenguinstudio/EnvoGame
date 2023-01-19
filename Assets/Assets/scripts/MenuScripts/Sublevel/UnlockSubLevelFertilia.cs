using UnityEngine;
using System.Collections;

public class UnlockSubLevelFertilia : HighScore {


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

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("a"+hiScore);
		if (hiScore <= 105 && hiScore > 100)
						SL1.SetActive (true);
				else if (hiScore <= 110 && hiScore > 105) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
				} else if (hiScore <= 115 && hiScore > 110) {
				
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);
				} else if (hiScore <= 120 && hiScore > 115) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);
				} else if (hiScore <= 125 && hiScore > 120) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
				} else if (hiScore <= 130 && hiScore > 125) {

						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
						SL6.SetActive (true);
				}
				else if (hiScore <= 135 && hiScore > 130) {
					
					SL1.SetActive (true);	
					SL2.SetActive (true);
					SL3.SetActive (true);			
					SL4.SetActive (true);			
					SL5.SetActive (true);
					SL6.SetActive (true);
					SL7.SetActive (true);
				}
		}
}
