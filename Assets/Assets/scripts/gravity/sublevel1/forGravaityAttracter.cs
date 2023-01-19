using UnityEngine;
using System.Collections;

public class forGravaityAttracter : MonoBehaviour {

	public float gravity = -1000;
	// Use this for initialization
	public void Attract(Transform body) {
		Vector2 gravityUp = (body.position - transform.position).normalized;
		Vector2 bodyUp = body.up;

		body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

		Quaternion targetRotation = Quaternion.FromToRotation(bodyUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp (body.rotation, targetRotation, 50 * Time.deltaTime);


	}
}
