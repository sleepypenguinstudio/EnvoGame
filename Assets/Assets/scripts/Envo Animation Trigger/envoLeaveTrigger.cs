using UnityEngine;
using System.Collections;

public class envoLeaveTrigger : MonoBehaviour {

	//public GameObject enVo;
	public AudioClip entryClip;
	// Use this for initialization
	void Start () {
		//enVo.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (CountDownC.timerInSecond);
		if (CountDownC.timerInSecond == 5) {
			GetComponent<AudioSource>().clip = entryClip ;
			GetComponent<AudioSource>().Play();
				}
		if (CountDownC.timerInSecond == 8) {
			//enVo.SetActive(true);
			Application.LoadLevel(16);
			}
	}
}
