using UnityEngine;
using System.Collections;

public class RandomRange : MonoBehaviour {

	// Use this for initialization
	public float LoadingTime;
	public float randomFactNum;
	public GameObject Fact1;
	public GameObject Fact2;
	public GameObject Fact3;
	public GameObject Fact4;
	public GameObject Fact5;
	public GameObject Fact6;
	public GameObject Fact7;
	public GameObject Fact8;
	public GameObject Fact9;
	public GameObject Fact10;


	void Start () {
		randomFactNum = Random.Range (0, 10);
		Fact1.SetActive (false);
		Fact2.SetActive (false);
		Fact3.SetActive (false);
		Fact4.SetActive (false);
		Fact5.SetActive (false);
		Fact6.SetActive (false);
		Fact7.SetActive (false);
		Fact8.SetActive (false);
		Fact9.SetActive (false);
		Fact10.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = 1;
		LoadingTime += Time.deltaTime;

		if (randomFactNum == 0) {

						Fact1.SetActive (true);
						Fact2.SetActive (false);
						Fact3.SetActive (false);
						Fact4.SetActive (false);
						Fact5.SetActive (false);
						Fact6.SetActive (false);
						Fact7.SetActive (false);
						Fact8.SetActive (false);
						Fact9.SetActive (false);
						Fact10.SetActive (false);


				} 
		else if (randomFactNum == 1) {
			Fact1.SetActive (false);
			Fact2.SetActive (true);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
				
		}

		else if (randomFactNum == 2) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (true);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 3) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (true);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 4) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (true);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 5) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (true);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 6) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (true);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}
		else if (randomFactNum == 7) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (true);
			Fact9.SetActive (false);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 8) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (true);
			Fact10.SetActive(false);
			
		}

		else if (randomFactNum == 9) {
			Fact1.SetActive (false);
			Fact2.SetActive (false);
			Fact3.SetActive (false);
			Fact4.SetActive (false);
			Fact5.SetActive (false);
			Fact6.SetActive (false);
			Fact7.SetActive (false);
			Fact8.SetActive (false);
			Fact9.SetActive (false);
			Fact10.SetActive(true);
			
		}


		if (LoadingTime > 7.0f && StaticFlag.curLevelLoading == 7 ) {
			Application.LoadLevel(12);
				}

		else if (LoadingTime > 7.0f && StaticFlag.curLevelLoading == 8 ) {
			Application.LoadLevel(22);
		}



	}
}
