using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private bool _isFacingRight;
	private CharacterController2D _controller; 
	private float _normalizedHorizintalSpeed; 
	
	public float MaxSpeed=8;
	public float SpeedAccelarationOnGroud=10f;
	public float SpeedAccelarationOnAir=5f;
	
	public void start()
	{
		_controller = GetComponent<CharacterController2D> ();
		_isFacingRight = transform.localScale.x > 0; //checking if it is facing right
		
	}
	public void update()
	{
		HandleInput (); //if player is dead then dont call it
		var movementfactor = _controller.State.IsGrounded ? SpeedAccelarationOnGroud : SpeedAccelarationOnAir;
		_controller.SetHorizontalForce (Mathf.Lerp (_controller.Velocity.x, _normalizedHorizintalSpeed * MaxSpeed, Time.deltaTime * movementfactor));
		
	}
	private void HandleInput()
	{
		if (Input.GetKey (KeyCode.D))
		{
			_normalizedHorizintalSpeed=1; //moving right
			if (!_isFacingRight)
				flip();
		}
		else if (Input.GetKey (KeyCode.A))
		{
			_normalizedHorizintalSpeed=-1; //moving left
			if (_isFacingRight)
				flip();
		}
		else 
		{
			_normalizedHorizintalSpeed=0; //moving right
			
		}
		if (_controller.CanJump && Input.GetKeyDown (KeyCode.Space)) {
			_controller.Jump();		
		}
		
		
		
	}
	
	private void flip()
	{
		transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.y);
		_isFacingRight = transform.localScale.x > 0; 
	}
}
