using UnityEngine;
using System.Collections;

public class TouchCameraControl : MonoBehaviour {
	public float MoveSensitivityX = 1.0f;
	public float MoveSensitivityY = 1.0f;
	public bool updateZoomSensitivity = true ;
	public float orthoZoomSpeed = 0.05f;
	public float minZoom = 1.0f;
	public float maxZoom = 20.0f;
	public bool invertMoveX = false;
	public bool invertMoveY = true;

	private Transform _transform;
	private Camera _camera;


	// Use this for initialization
	void Start () {
		_transform = transform;
		_camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if (updateZoomSensitivity) {
			MoveSensitivityX =_camera.orthographicSize / 5.0f;
			MoveSensitivityY =_camera.orthographicSize /5.0f;
		}
		Touch [] touches = Input.touches; 
		if (touches.Length > 0) {

			//if(touches.Length == 1)		
		}
	}
}
