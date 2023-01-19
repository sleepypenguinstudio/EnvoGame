using UnityEngine;
using System.Collections;

public class UnlockSubLevelMathanus : HighScore {


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
		if (hiScore <= 140 && hiScore > 135)
						SL1.SetActive (true);
				else if (hiScore <= 145 && hiScore > 140) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
				} else if (hiScore <= 150 && hiScore > 145) {
				
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);
				} else if (hiScore <= 155 && hiScore > 150) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);
				} else if (hiScore <= 160 && hiScore > 155) {
						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
				} else if (hiScore <= 165 && hiScore > 160) {

						SL1.SetActive (true);	
						SL2.SetActive (true);
						SL3.SetActive (true);			
						SL4.SetActive (true);			
						SL5.SetActive (true);
						SL6.SetActive (true);
				}
				else if (hiScore <= 170 && hiScore > 165) {
					
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
