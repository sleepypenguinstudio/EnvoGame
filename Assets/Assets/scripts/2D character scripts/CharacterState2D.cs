using UnityEngine;
using System.Collections;

public class CharacterState2D  {

	public bool IsCollidingRight{ get; set;}
	public bool IsCollidingLeft{ get; set;}
	public bool IsCollidingAbove{ get; set;}
	public bool IsCollidingBelow{ get; set;}
	public bool IsMovingUpSlope{ get; set;}
	public bool IsMovingDownSlope{ get; set; }
	public bool IsGrounded{get {return IsCollidingBelow;}}
	public float slopeAngle { get; set;}
	public bool HasCollisions{get{return IsCollidingRight ||IsCollidingLeft || IsCollidingAbove || IsCollidingBelow ;}}

	public void Reset()
	{
		IsCollidingAbove =
			IsCollidingLeft =
				IsCollidingBelow =
				IsCollidingRight =
				IsMovingUpSlope =
				IsMovingDownSlope = false;
		slopeAngle = 0; 
	}
	public override string ToString ()
	{
		return string.Format ("[CharacterState2D: IsCollidingRight={0}, IsCollidingLeft={1}, IsCollidingAbove={2}, IsCollidingBelow={3}, IsMovingUpSlope={4}, IsMovingDownSlope={5}, IsGrounded={6}, slopeAngle={7}, HasCollisions={8}]", IsCollidingRight, IsCollidingLeft, IsCollidingAbove, IsCollidingBelow, IsMovingUpSlope, IsMovingDownSlope, IsGrounded, slopeAngle, HasCollisions);
	}




}
