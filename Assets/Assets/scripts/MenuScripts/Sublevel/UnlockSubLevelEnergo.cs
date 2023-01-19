using UnityEngine;
using System.Collections;

public class UnlockSubLevelEnergo : HighScore {


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
		if (hiScore <= 70  && hiScore > 65 )
						SL1.SetActive (true);
				else if (hiScore <= 75 && hiScore > 70) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
				} else if (hiScore <= 80 && hiScore > 75) {
				
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);
				} else if (hiScore <= 85 && hiScore > 80) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);
				} else if (hiScore <= 90 && hiScore > 85) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
				} else if (hiScore <= 95 && hiScore > 90) {

						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
						SL6.SetActive (true);
				}
				else if (hiScore <= 100 && hiScore > 95) {
					
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
