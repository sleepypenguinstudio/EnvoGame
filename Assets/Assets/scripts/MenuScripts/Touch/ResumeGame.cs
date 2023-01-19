using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {
	
	
	//public int LevelToLoad;
	public Color defaultColor;
	public Color selectedColor;
	private Material mat ;  
	
	
	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
	}
	
	void OnTouchUp(){
		mat.color = selectedColor;
		StaticFlag.tocuhResume = 1;

	}
	
	void OnTouchStay(){
		mat.color = selectedColor;
	}
	
	void OnTouchExit(){
		mat.color = defaultColor;
	}
}


