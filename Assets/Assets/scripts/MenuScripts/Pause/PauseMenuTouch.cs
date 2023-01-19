using UnityEngine;
using System.Collections;

public class PauseMenuTouch : MonoBehaviour {
	
	private int buttonwidth = 200;
	private int buttonheight = 50;
	private int groupwidth = 200;
	private int groupheight = 170;
	bool paused = false ; 
	public GameObject Resume;
	public GameObject Restart;
	public GameObject Menu;
	public GameObject Pause;
	
	
	// Use this for initialization
	void Start () {
		Pause.SetActive (true);
		Resume.SetActive (false);
		Restart.SetActive (false);
		Menu.SetActive (false);
		//Screen.lockCursor = true;
		Time.timeScale = 1;
	}
	
	
	/*void OnGUI ()
	{
		if (paused) {
			/*GUI.BeginGroup(new Rect(((Screen.width/2) - (groupwidth/2)),((Screen.height/2) - (groupheight/2)),groupwidth,groupheight));
			if(GUI.Button(new Rect(0,0,buttonwidth,buttonheight),"Main Menu"))
				Application.LoadLevel(0);
			if(GUI.Button(new Rect(0,60,buttonwidth,buttonheight),"Restart Game"))
				Application.LoadLevel(3);

			if(GUI.Button(new Rect(0,0,buttonwidth,buttonheight),"Main Menu"))
				Application.Quit();
			GUI.EndGroup();


		}
	}*/
	
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape) || (StaticFlag.pause == 1 && StaticFlag.pauseable == 0)) {
			
			//paused = togglePause ();
			Debug.Log ("g" + Time.timeScale);
			Time.timeScale = 0 ;
			Debug.Log ("gj" + Time.timeScale);
			Pause.SetActive (false);
			Resume.SetActive (true);
			Restart.SetActive (true);
			Menu.SetActive (true);
			//Screen.lockCursor = true;
			//Time.timeScale = 1;
			//StaticFlag.tocuhResume = 0;	
			//return(false);
		} else if (StaticFlag.pause == 0 && StaticFlag.pauseable == 1) {

			Time.timeScale = 1;
			Pause.SetActive (true);
			Resume.SetActive (false);
			Restart.SetActive (false);
			Menu.SetActive (false);
			//Screen.lockCursor = true;
			//Time.timeScale = 1;
			//StaticFlag.tocuhResume = 0;	
			//return(false);
		}
	}
	
	/*bool togglePause()
	{
		if (Time.timeScale == 0) {
			
			Pause.SetActive (false);
			Resume.SetActive (true);
			Restart.SetActive (true);
			Menu.SetActive (true);
			Screen.lockCursor = true;
			Time.timeScale = 1;
			StaticFlag.tocuhResume	= 0;	
			return(false);
		} 
		else {
			Pause.SetActive (true);
			Resume.SetActive (false);
			Restart.SetActive (false);
			Menu.SetActive (false);
			Screen.lockCursor = false ;
			Time.timeScale = 0 ;
			StaticFlag.tocuhResume	= 1;	
			return(true);			
		}
	}*/
}
