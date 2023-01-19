using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform Player;
	public bool rFlag;

	public Vector2 
		Margin,
		Smoothing;

	//public BoxCollider2D Bounds;
	private Vector3 
		_min,
		_max;

	public bool IsFollowing { get; set;}

	public void Start()
	{
	//	_min = Bounds.bounds.min;
	//	_max = Bounds.bounds.max;
		IsFollowing = true;
	}
	public void Update()
	{
		/*Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;*/

		var x = transform.position.x;
		var y = transform.position.y;
		if (IsFollowing) {
			if (Mathf.Abs(x - Player.position.x)>Margin.x)
				x= Mathf.Lerp(x,Player.position.x,Smoothing.x*Time.deltaTime);

			if (Mathf.Abs(y - Player.position.y)>Margin.y)
				y= Mathf.Lerp(y,Player.position.y,Smoothing.y*Time.deltaTime);
		}

//		var CameraHalfWidth = camera.orthographicSize * ((float)Screen.width / Screen.height);
		//x = Mathf.Clamp (x,  -camera.orthographicSize,  camera.orthographicSize);
		//y = Mathf.Clamp (y, -camera.orthographicSize,  camera.orthographicSize);

		transform.position = new Vector3 (x,y, transform.position.z);


		//transform.rotation = Quaternion.AngleAxis(Player.eulerAngles.z, new Vector3(0,0,1));
		if (rFlag) {
						transform.rotation = Quaternion.AngleAxis (Player.eulerAngles.z, new Vector3 (0, 0, 1));		
				}
		else if (!rFlag) {
			transform.rotation = Quaternion.AngleAxis (-Player.eulerAngles.z, new Vector3 (0, 0, 1));	
		}



		if (Input.GetKey (KeyCode.RightArrow) || (StaticFlag.LeftFlag == 0 && StaticFlag.RightFlag == 1)) {
			transform.rotation = Quaternion.AngleAxis(Player.eulerAngles.z, new Vector3(0,0,1));
			rFlag = true;
		} else if (Input.GetKey (KeyCode.LeftArrow) || (StaticFlag.LeftFlag == 1 && StaticFlag.RightFlag == 0)) {
			transform.rotation = Quaternion.AngleAxis(-Player.eulerAngles.z, new Vector3(0,0,1));
			rFlag = false ;
		}

		//Debug.Log ("Z: "+Player.rotation.z);
	}
}

