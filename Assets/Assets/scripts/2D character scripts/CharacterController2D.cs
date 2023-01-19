using UnityEngine;
using System.Collections;

public class CharacterController2D : MonoBehaviour {

	public const float SkinWidth= 0.02f;
	public const int TotalHorizontalRays= 8;
	public const int TotalVerticalRays= 8;

	public static readonly float SlopeLimitTangent = Mathf.Tan (75f* Mathf.Deg2Rad);
	 
	public LayerMask PlatformMask;
	public CharacterControllerParameters2D DefaultParamers;

	public CharacterState2D State {get; private set;}
	public Vector2 Velocity { get; private set;}
	public bool CanJump{get{return false;}}

	public void Awake()
	{
		State = new CharacterState2D (); 
	}
 public void AddForce(Vector2 force)
	{

	}

	public void SetForce(Vector2 force)
	{
		
	}
	public void SetHorizontalForce(float force)
	{
		
	}
	public void SetVerticalForce(float force)
	{
		
	}
	public void Jump()
	{

	}
	public void LateUpdate()
	{

	}
	private void Move(Vector2 deltamovement)
	{
		}
	private void HandlePlatforms()
	{

	}
	private void CalculateRayOrifins()
	{

	}
	private void MoveHorizontally(ref Vector2 deltamovement )
	{

	}
	private void MoveVertically(ref Vector2 deltamovement )
	{

	}
	private void HandleVerticalSlope(ref Vector2 deltamovement )
	{
	}

	private void HandleHorizontalSlope(ref Vector2 deltamovement, float angle, bool IsGoingRight )
	{

	}
	public void OnTriggerEnter2D(Collider2D other)
	{

	}
	public void OnTriggerExit2D(Collider2D other)
	{
	
	}

}
