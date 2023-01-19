using UnityEngine;
using System.Collections;

public class touchMovementJump : MonoBehaviour {
	
	//public touchMovementRight rt;
	//public int leftFlag;
	public Color defaultColor;
	public Color selectedColor;
	private Material mat ;  
	
	
	void OnTouchDown(){
		mat = GetComponent<Renderer>().material;
		StaticFlag.JumpFlag = 1; 
	}
	
	void OnTouchUp(){
		mat.color = selectedColor;
		StaticFlag.JumpFlag = 0; 
		//StaticFlag.RightFlag = 2;
		//RightFlag = 0;
	}
	
	void OnTouchStay(){
		mat.color = selectedColor;
		StaticFlag.JumpFlag = 1; 

		//StaticFlag.RightFlag = 0;
	}
	
	void OnTouchExit(){
		mat.color = defaultColor;
		StaticFlag.JumpFlag = 0;
	}
}
