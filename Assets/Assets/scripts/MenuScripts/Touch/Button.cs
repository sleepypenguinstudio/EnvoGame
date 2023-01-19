using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {


	public int LevelToLoad;
	public Color defaultColor;
	public Color selectedColor;
	private Material mat ;  


	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
	}

	void OnTouchUp(){
		/*mat.color = selectedColor;
		float fadeTime = GameObject.Find ("BG_txtr").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);*/
        Fading.alpha = 0; 
		multipleGravity.Flag = 1;
		Application.LoadLevel (LevelToLoad);
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
