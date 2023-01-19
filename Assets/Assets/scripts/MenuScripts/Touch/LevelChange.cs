using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	public GameObject Ox0;
	public GameObject Ox1;
	public GameObject Ox2;
	public GameObject Ox3;
	public GameObject Ox4;
	public GameObject Ox5;
	//public int levelToLoad ;

	// Use this for initialization
	void Start () {
		Ox0.SetActive(true);
		Ox1.SetActive(false);
        Ox2.SetActive(false);
        Ox3.SetActive(false);
        Ox4.SetActive(false);
        Ox5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (StaticFlag.TotalOx);
		if (StaticFlag.TotalOx == 1) {
			//Debug.Log ("col");
			//Destroy(gameObject,.1f);
			//Instantiate(Ox1,transform.position,transform.rotation);
        Ox0.SetActive(false);
        Ox1.SetActive(true);
        Ox2.SetActive(false);
        Ox3.SetActive(false);
        Ox4.SetActive(false);
        Ox5.SetActive(false);
		}
		else if(StaticFlag.TotalOx == 2) {
			//Destroy(Ox1,.1f);
			//Instantiate(Ox2,transform.position,transform.rotation);
        Ox0.SetActive(false);
        Ox1.SetActive(false);
        Ox2.SetActive(true);
        Ox3.SetActive(false);
        Ox4.SetActive(false);
        Ox5.SetActive(false);
		}
		else if(StaticFlag.TotalOx == 3) {
			//Destroy(Ox2,.1f);
			//Instantiate(Ox3,transform.position,transform.rotation);
        Ox0.SetActive(false);
        Ox1.SetActive(false);
        Ox2.SetActive(false);
        Ox3.SetActive(true);
        Ox4.SetActive(false);
        Ox5.SetActive(false);
		}
		else if(StaticFlag.TotalOx == 4) {
			//Destroy(Ox3,.1f);
			//Instantiate(Ox4,transform.position,transform.rotation);
        Ox0.SetActive(false);
        Ox1.SetActive(false);
        Ox2.SetActive(false);
        Ox3.SetActive(false);
        Ox4.SetActive(true);
        Ox5.SetActive(false);
		}
		else if(StaticFlag.TotalOx == 5) {
			//Destroy(Ox4,.1f);
			//Instantiate(Ox5,transform.position,transform.rotation);
            Ox0.SetActive(false);
            Ox1.SetActive(false);
            Ox2.SetActive(false);
            Ox3.SetActive(false);
            Ox4.SetActive(false);
            Ox5.SetActive(true);

			//Application.LoadLevel ();
		}
	}
}
