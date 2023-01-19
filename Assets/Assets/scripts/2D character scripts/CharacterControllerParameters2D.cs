using UnityEngine;
using System.Collections;
[SerializeField]
public class CharacterControllerParameters2D  {

	public enum JumpBehavior
	{
		CanJumpOnGround,
		CanJumpAnywhere,
		CantJump
	}
	public Vector2 MaxVelocity = new Vector2(float.MaxValue, float.MaxValue);
	//[Range(0,30)]
	public float slopelimit = 30;

	public JumpBehavior jumpRestriction;
	public float JumpFrequency= 0.25f;
	public float Gravity= -25f;
}
