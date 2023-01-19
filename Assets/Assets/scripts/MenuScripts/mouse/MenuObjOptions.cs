using UnityEngine;
using System.Collections;

public class MenuObjOptions : MonoBehaviour 
{
	//public bool isQuit = false;
	
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.grey;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseDown()
	{
		
		Application.LoadLevel(4);	
	}
	
	
}
