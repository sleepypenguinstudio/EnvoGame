using UnityEngine;
using System.Collections;

public class TouchHint : MonoBehaviour {
	
	//public touchMovementRight rt;
	//public int leftFlag;
	//public Color defaultColor;
	//public Color selectedColor;
	private Material mat ;  
	
	
	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
		StaticFlag.hintShow = 1;
		StaticFlag.showable = 0;

		//StaticFlag.pause = 1;
	}
	
	void OnTouchUp(){
		//mat.color = selectedColor;
		StaticFlag.hintShow = 0; 
		StaticFlag.showable = 1;

		//StaticFlag.pause = 0;
		//StaticFlag.pause = 1;
		//StaticFlag.RightFlag = 2;
		//RightFlag = 0;
	}
	
	void OnTouchStay(){
		//mat.color = selectedColor;
		//StaticFlag.pause = 1;
		//StaticFlag.pauseable = 0;
		
		//StaticFlag.RightFlag = 0;
	}
	
	void OnTouchExit(){
		//mat.color = defaultColor;
		//StaticFlag.pause = 0; 
		//StaticFlag.pauseable = 1;
	}
}
