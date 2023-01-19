using UnityEngine;
using System.Collections;

public class SubLevelButton : MonoBehaviour {


	public int LevelToLoad;
	public Color defaultColor;
	public Color selectedColor;
	private Material mat ; 
	 

	void Start () {
		StaticFlag.curLevelLoading = Application.loadedLevel;

	}
	/*void Update () {

		Debug.Log (StaticFlag.EnvoEntryLevelToLoad);
	}*/
	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
	}

	void OnTouchUp(){
		/*mat.color = selectedColor;
		float fadeTime = GameObject.Find ("BG_txtr").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);*/
		StaticFlag.EnvoEntryLevelToLoad = LevelToLoad;
		Fading.alpha = 0; 
		Debug.Log ("\n" + StaticFlag.EnvoEntryLevelToLoad);
		Application.LoadLevel (21);
        StaticFlag.pauseable = 1;
        StaticFlag.pause = 0;
	}

	void OnTouchStay(){
		mat.color = selectedColor;
	}

	void OnTouchExit(){
		mat.color = defaultColor;
	}
}
