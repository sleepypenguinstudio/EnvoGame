using UnityEngine;
using System.Collections;

public class FirstPersonControllerCameraInsidePlayer : MonoBehaviour {

	
	public float jumpHeight = 50;
	//bool isGrounded = true;
	//public Transform lineStart, lineEnd, groundedEnd;
	private Vector2 amountToMove;


	void Update() {
		

		Movement ();
		if(Input.GetButtonDown("Jump"))
			Jump();
		//#else

	

	}
	
	void Movement()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector2.right * 4f * Time.deltaTime );
			transform.eulerAngles = new Vector3(0,0,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(Vector2.right * 4f * Time.deltaTime );
			transform.eulerAngles = new Vector3(0,180,0);
		}


		}
	void Jump()
	{
		//if(isGrounded)
			transform.Translate( Vector2.up *jumpHeight* 2f * Time.deltaTime);

	}




}