using UnityEngine;
using System.Collections;

public class IntroWalk : MonoBehaviour {

	public float walkingTime;

	//Animator anim;
	public GameObject Player;
	public GameObject EnvoEntry;
	public GameObject EnvoLeave;
	


	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		//anim.SetBool ("stop", false);
		EnvoEntry.SetActive (false);
		EnvoLeave.SetActive (false);
		Player.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		walkingTime += Time.deltaTime;

		if(walkingTime < 3)
			Player.transform.Translate(Vector2.right * 4f * Time.deltaTime);
		else
			transform.Translate (Vector2.zero);
			//anim.SetBool("stop",true);

		if (walkingTime >= 13.30f)
						EnvoEntry.SetActive (true);
		if (walkingTime >= 21f) {
						EnvoLeave.SetActive (true);
						EnvoEntry.SetActive (false);
						Player.SetActive(false);
						
				}
		if (walkingTime >= 26.5f) {				
			//Debug.Log ("go");			
			EnvoLeave.SetActive (false);
						Application.LoadLevel (2);
				}


	}
}
