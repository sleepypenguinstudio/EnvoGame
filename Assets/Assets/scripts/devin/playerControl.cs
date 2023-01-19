using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour
{
	public float speed = 10, jumpVelocity = 10;
	public LayerMask playerMask;
	public bool canMoveInAir = true;
	Transform myTrans, tagGround;
	Rigidbody2D myBody;
	bool isGrounded = false;
	float hInput = 0;
	
	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;
	}
	void FixedUpdate ()
	{
		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);
		
		//if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT || UNITY_EDITOR
		Move(Input.GetAxisRaw("Horizontal"));
		if(Input.GetButtonDown("Jump"))
			Jump();
		//#else
		Move (hInput);
		//#endif
	}
	
	void Move(float horizonalInput)
	{
		if(!canMoveInAir && !isGrounded)
			return;
		
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizonalInput * speed;
		myBody.velocity = moveVel;
	}
	
	public void Jump()
	{
		if(isGrounded)
			myBody.velocity += jumpVelocity * Vector2.up;
	}
	
	public void StartMoving(float horizonalInput)
	{
		hInput = horizonalInput;
	}
}