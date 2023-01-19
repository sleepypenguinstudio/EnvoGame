
using UnityEngine;
using System.Collections;

public class forGracityBody : MonoBehaviour {
	public forGravaityAttracter[] attracter = new forGravaityAttracter[5]; 
	public multipleGravity[] amg = new multipleGravity[5];
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform; 
		for (int i=0; i<5; i++)
						attracter [i].gravity = 0;
		attracter[0].gravity = -70; 
		attracter[0].Attract(myTransform);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<5; i++)
			attracter [i].gravity = 0;   
		int x = multipleGravity.Flag - 1; 
		attracter [x].gravity = -70;
		attracter [x].Attract (myTransform); 
	} 

}
