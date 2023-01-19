using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour
{
    //public Transform PlayerNewPos; // for portal
    //// public Transform PlayerOldPos; // for portal
    //public Vector3 portalPos;
    //public Transform Camera; 
	public float jumpHeight = 180;
	public bool isGrounded = true;
	public Transform groundedEnd;
	private Vector2 amountToMove;
	


	Animator anim;

	private bool R;

	public float jumpTime;
	private float jumpDelay =0.5f;

	bool jumped;
	void Start()
	{
		R = true;
		anim = GetComponent<Animator> ();
		//elapsedJumpTime = 0;
	}
	
	void Update()
	{

		/*if (isGrounded == false) {
			elapsedJumpTime += Time.deltaTime;
		}

		if (elapsedJumpTime >= jumpTime) {
			anim.SetBool("isJumping",false);
			elapsedJumpTime = 0;
		}*/

		anim.SetBool("isRunning",false);

		Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;
		
		Movement();
		isGrounded = Physics.Linecast(this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer("ground"));
		if ((Input.GetButtonDown ("Jump") && isGrounded == true) || (StaticFlag.JumpFlag == 1 && isGrounded == true)) {
			//Time.timeScale = 0.001f ;			
			//anim.SetBool("isJumping",false);

			Jump ();
		}
		//.timeScale = 1 ;	
		//#else
		jumpTime -= Time.deltaTime;
		if (jumpTime <= 0 && isGrounded && jumped) {
			anim.SetTrigger("Land");
			jumped = false;
				}
		
		
		
	}
	
	void Movement()
	{
		Vector3 flip = new Vector3(0, 180, 0);
		if (R)
		{

			if (Input.GetKey(KeyCode.RightArrow) || (StaticFlag.LeftFlag == 0 && StaticFlag.RightFlag == 1))
			{
				anim.SetBool("isRunning",true);
				if (isGrounded==true)
				{
					//anim.SetBool("isJumping",false);
					transform.Translate(Vector2.right * 8f * Time.deltaTime);
				}
				else
				{
					//anim.SetBool("isJumping",true);
					transform.Translate(Vector2.right * 8f * Time.deltaTime);
				}

			}
			else if (Input.GetKey(KeyCode.LeftArrow) || (StaticFlag.LeftFlag == 1 && StaticFlag.RightFlag == 0))
			{
				anim.SetBool("isRunning",true);
				Vector3 pos = transform.position;
				pos.z = 0;
				transform.position = pos;
				transform.Rotate(flip);
				R = false;
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.RightArrow) || (StaticFlag.LeftFlag == 0 && StaticFlag.RightFlag == 1))
			{
				anim.SetBool("isRunning",true);
				transform.Rotate(flip);
				R = true;
			}
			else if (Input.GetKey(KeyCode.LeftArrow) || (StaticFlag.LeftFlag == 1 && StaticFlag.RightFlag == 0))
			{
				anim.SetBool("isRunning",true);
				if (isGrounded==true)
					transform.Translate(Vector2.right * 8f * Time.deltaTime);
				else
					transform.Translate(Vector2.right * 8f * Time.deltaTime);
			}
		}
	}
	void Jump()
	{

		anim.SetBool("isRunning",false);

		GetComponent<Rigidbody>().velocity = Vector3.forward * jumpHeight;
		//anim.SetBool ("isJumping",true);
		jumpTime = jumpDelay;
		anim.SetTrigger("Jump");
		jumped = true;

		
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "spring")
		{
			transform.Translate(Vector2.up * jumpHeight * .4f * Time.deltaTime);
		}
        //if (col.gameObject.name == "aqua portal in1")
        //{
        //    Camera.transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.z, new Vector3(0, 0, 1));
        //    portalPos = PlayerNewPos.transform.position;

        //    if (multipleGravity.Flag == 2)
        //    {
                
        //    //    gameObject.SetActive(false);
        //        gameObject.transform.position = portalPos;
        //        multipleGravity.Flag = 8;
        //      //  gameObject.SetActive(true);

        //    }

        //}
	}
	
	
}