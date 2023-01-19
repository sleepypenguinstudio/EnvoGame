using UnityEngine;
using System.Collections;

public class HintButtonTouch : MonoBehaviour {
	
	private int buttonwidth = 200;
	private int buttonheight = 50;
	private int groupwidth = 200;
	private int groupheight = 170;
	bool paused = false ; 
	public GameObject GUIBackground;
    public GameObject camera;
    public GameObject hint;
	public float timeOfZoom ;
	
	
	
	// Use this for initialization
	void Start () {
		GUIBackground.SetActive (true);
		camera.SetActive (false);
        hint.SetActive(true);
		//Restart.SetActive (false);
		//Menu.SetActive (false);
		//Screen.lockCursor = true;
		//Time.timeScale = 1;
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
        if (StaticFlag.hintShow == 1 && StaticFlag.showable == 0)
        {
						timeOfZoom += Time.deltaTime;
						//paused = togglePause ();
						//Time.timeScale = 0;
                       // Back.SetActive(true);
						GUIBackground.SetActive (false);
                        camera.SetActive(true);
                        hint.SetActive(false);
			  			Debug.Log(timeOfZoom );


				
			if (timeOfZoom >= 5.0f)
			{
				//Time.timeScale = 1;
				// Back.SetActive(false);
				GUIBackground.SetActive (true);
				camera.SetActive(false);
				hint.SetActive(true);
				Debug.Log("Dhuksi");
				StaticFlag.hintShow = 0;
				StaticFlag.showable = 1;
				timeOfZoom = 0;
				
				
				//   StaticFlag.pause = 0;
				//  StaticFlag.pauseable = 1;
				//Screen.lockCursor = true;
				//Time.timeScale = 1;
				//StaticFlag.tocuhResume = 0;	
				//return(false);
			}

				
				//Screen.lockCursor = true;
				//Time.timeScale = 1;
				//StaticFlag.tocuhResume = 0;	
				//return(false);
				//   StaticFlag.pause = 1;
				// StaticFlag.pauseable = 0;
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
