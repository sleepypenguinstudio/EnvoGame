using UnityEngine;
using System.Collections;

public class StarCount1 : MonoBehaviour {
	
	
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public GameObject star4;
	public GameObject star5;
	public GameObject star6;
	public GameObject star7;
	public GameObject star8;
	public GameObject star9;
	public GameObject star10;
	public GameObject star11;
	public GameObject star12;
	public GameObject star13;
	public GameObject star14;
	public GameObject star15;
	public GameObject star16;
	public GameObject star17;
	public GameObject star18;
	public GameObject star19;
	public GameObject star20;
	public GameObject star21;
	
	
	//public static int starNum;
	// Use this for initialization
	void Start () {
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
		star4.SetActive (false);
		star5.SetActive (false);
		star6.SetActive (false);
		star7.SetActive (false);
		star8.SetActive (false);
		star9.SetActive (false);
		star10.SetActive (false);
		star11.SetActive (false);
		star12.SetActive (false);
		star13.SetActive (false);
		star14.SetActive (false);
		star15.SetActive (false);
		star16.SetActive (false);
		star17.SetActive (false);
		star18.SetActive (false);
		star19.SetActive (false);
		star20.SetActive (false);
		star21.SetActive (false);
		
		/*PlayerPrefs.SetInt ("StarNum12", 0);
		PlayerPrefs.SetInt ("StarNum22", 0);
		PlayerPrefs.SetInt ("StarNum32", 0);
		PlayerPrefs.SetInt ("StarNum42", 0);
		PlayerPrefs.SetInt ("StarNum52", 0);
		PlayerPrefs.SetInt ("StarNum62", 0);
		PlayerPrefs.SetInt ("StarNum72", 0);*/
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelComplete1a1.starNo > PlayerPrefs.GetInt("StarNum12")) {
			PlayerPrefs.SetInt("StarNum12",LevelComplete1a1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum12") == 0) {
			star1.SetActive (false);
			star2.SetActive (false);
			star3.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum12") == 1)
		{
			star1.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum12") == 2)
		{	
			star1.SetActive(true);
			star2.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum12") == 3)
		{	
			star1.SetActive(true);
			star2.SetActive(true);
			star3.SetActive(true);
		}
		
		if (LevelComplete1b1.starNo > PlayerPrefs.GetInt("StarNum22")) {
			PlayerPrefs.SetInt("StarNum22",LevelComplete1b1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum22") == 0) {
			star4.SetActive (false);
			star5.SetActive (false);
			star6.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum22") == 1)
		{
			star4.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum22") == 2)
		{	
			star4.SetActive(true);
			star5.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum22") == 3)
		{	
			star4.SetActive(true);
			star5.SetActive(true);
			star6.SetActive(true);
		}
		
		if (LevelComplete1c1.starNo > PlayerPrefs.GetInt("StarNum32")) {
			PlayerPrefs.SetInt("StarNum32",LevelComplete1c1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum32") == 0) {
			star7.SetActive (false);
			star8.SetActive (false);
			star9.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum32") == 1)
		{
			star7.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum32") == 2)
		{	
			star7.SetActive(true);
			star8.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum32") == 3)
		{	
			star7.SetActive(true);
			star8.SetActive(true);
			star9.SetActive(true);
		}
		
		
		if (LevelComplete1d1.starNo > PlayerPrefs.GetInt("StarNum42")) {
			PlayerPrefs.SetInt("StarNum42",LevelComplete1d1.starNo);
		}
		
		if (PlayerPrefs.GetInt ("StarNum42") == 0) {
			star10.SetActive (false);
			star11.SetActive (false);
			star12.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum42") == 1)
		{
			star10.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum42") == 2)
		{	
			star10.SetActive(true);
			star11.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum42") == 3)
		{	
			star10.SetActive(true);
			star11.SetActive(true);
			star12.SetActive(true);
		}
		
		if (LevelComplete1e1.starNo > PlayerPrefs.GetInt("StarNum52")) {
			PlayerPrefs.SetInt("StarNum5",LevelComplete1e1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum52") == 0) {
			star13.SetActive (false);
			star14.SetActive (false);
			star15.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum52") == 1)
		{
			star13.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum52") == 2)
		{	
			star13.SetActive(true);
			star14.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum52") == 3)
		{	
			star13.SetActive(true);
			star14.SetActive(true);
			star15.SetActive(true);
		}
		
		if (LevelComplete1f1.starNo > PlayerPrefs.GetInt("StarNum62")) {
			PlayerPrefs.SetInt("StarNum62",LevelComplete1f1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum62") == 0) {
			star16.SetActive (false);
			star17.SetActive (false);
			star18.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum62") == 1)
		{
			star16.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum62") == 2)
		{	
			star16.SetActive(true);
			star17.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum62") == 3)
		{	
			star16.SetActive(true);
			star17.SetActive(true);
			star18.SetActive(true);
		}
		
		if (LevelComplete1g1.starNo > PlayerPrefs.GetInt("StarNum72")) {
			PlayerPrefs.SetInt("StarNum72",LevelComplete1g1.starNo);
		}
		
		
		if (PlayerPrefs.GetInt ("StarNum72") == 0) {
			star19.SetActive (false);
			star20.SetActive (false);
			star21.SetActive (false);	
		}
		else if(PlayerPrefs.GetInt("StarNum72") == 1)
		{
			star19.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum72") == 2)
		{	
			star19.SetActive(true);
			star20.SetActive(true);
		}
		else if(PlayerPrefs.GetInt("StarNum72") == 3)
		{	
			star19.SetActive(true);
			star20.SetActive(true);
			star21.SetActive(true);
		}
		/*Debug.Log ("lowest time in level 7 " + PlayerPrefs.GetInt ("Time In Second Level 1g") + "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum7") + "\n");
		Debug.Log ("lowest time in level 6 " + PlayerPrefs.GetInt ("Time In Second Level 1f")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum6")+ "\n");
		Debug.Log ("lowest time in level 5 " + PlayerPrefs.GetInt ("Time In Second Level 1e")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum5")+ "\n");
		Debug.Log ("lowest time in level 4 " + PlayerPrefs.GetInt ("Time In Second Level 1d")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum4")+ "\n");
		Debug.Log ("lowest time in level 3 " + PlayerPrefs.GetInt ("Time In Second Level 1c")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum3")+ "\n");
		Debug.Log ("lowest time in level 2 " + PlayerPrefs.GetInt ("Time In Second Level 1b")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum2")+ "\n");
		Debug.Log ("lowest time in level 1 " + PlayerPrefs.GetInt ("Time In Second Level 1a")+ "\n");
		Debug.Log (PlayerPrefs.GetInt ("StarNum1")+ "\n");*/
		
		
	}

}
