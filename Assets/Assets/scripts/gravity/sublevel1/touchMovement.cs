using UnityEngine;
using System.Collections;

public class touchMovement : MonoBehaviour {
	
	//public touchMovementRight rt;
	//public int leftFlag;
	public Color defaultColor;
	public Color selectedColor;
	private Material mat ;  
	
	
	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
	}
	
	void OnTouchUp(){
		mat.color = selectedColor;
		StaticFlag.LeftFlag = 3; 
		StaticFlag.RightFlag = 2;
		//RightFlag = 0;
	}
	
	void OnTouchStay(){
		mat.color = selectedColor;
		StaticFlag.LeftFlag = 1;
		StaticFlag.RightFlag = 0;
	}
	
	void OnTouchExit(){
		mat.color = defaultColor;
		StaticFlag.LeftFlag = 3; 
		StaticFlag.RightFlag = 2;
	}
}
