using UnityEngine;
using System.Collections;

public class Sublevel1 : MonoBehaviour 
{
	//public bool isQuit = false;
	
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseDown()
	{
		
		Application.LoadLevel(3);	
	}
	
	
}
