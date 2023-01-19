using UnityEngine;
using System.Collections;

public class envoEntryTrigger : MonoBehaviour {

	//public GameObject enVo;
	//public static int EnvoEntryLevelToLoad =0;
	public AudioClip entryClip;
	// Use this for initialization
	void Start () {
		//enVo.SetActive (false);
		Debug.Log (StaticFlag.EnvoEntryLevelToLoad);
		CountDownC.timerInSecond = 0;
	}

	/*void Update () {
		StaticFlag.EnvoEntryLevelToLoad = LevelToLoad;
		}*/
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (CountDownC.timerInSecond);
		if (CountDownC.timerInSecond == 3) {
			GetComponent<AudioSource>().clip = entryClip ;
			GetComponent<AudioSource>().Play();
				}
		print (CountDownC.timerInSecond);
		if (CountDownC.timerInSecond == 8) {
			//enVo.SetActive(true);

			//LevelComplete1a.starNo = 0;
			Application.LoadLevel(StaticFlag.EnvoEntryLevelToLoad);
			}
	}
}
