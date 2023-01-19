
using UnityEngine;
using System.Collections;

public class forGracityBody1 : MonoBehaviour {
	public forGravaityAttracter[] attracter = new forGravaityAttracter[3]; 
	public multipleGravity[] amg = new multipleGravity[3];
	private Transform myTransform;
	public Transform Camera;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform; 
		for (int i=0; i<3; i++)
						attracter [i].gravity = 0;
		attracter[0].gravity = -1000; 
		attracter[0].Attract(myTransform);
		Debug.Log ("morsi");
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<3; i++)
			attracter [i].gravity = 0;   
		int x = multipleGravity.Flag - 1;
		Camera.transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.z, new Vector3(0,0,1));
		attracter [x].gravity = -1000;
		attracter [x].Attract (myTransform); 
	} 

}
