using UnityEngine;
using System.Collections;

public class enemygravity : MonoBehaviour {
	
	public forGravaityAttracter attracter;
	//public forGravaityAttracter attracter2;
	//public multipleGravity amg;
	private Transform myTransform;

	//public Transform player;
	float distancefrom_player;
	public float look_range = 20.0f;
	public float agro_range= 10.0f;
	public float move_speed= 5.0f;
	public float damping = 6.0f;
	public Transform sightStart;
	public Transform sightEnd;
	public LayerMask detectWhat;
	private int flag=180;
	
	public bool colliding;
	 
	public float velocity = .1f;
	// Use this for initialization
	void Start () {
		//rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform;

		colliding = false;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;

		attracter.Attract(myTransform);
      //  transform.Rotate(0, 0, 360);
		

		colliding = Physics.Linecast (sightStart.position, sightEnd.position, detectWhat);
		
		if (colliding) {
			
			//transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
			//velocity*= -1;
			if(flag==0)
			{
				flag=180;
			
			}
			else if(flag==180)
			{
				flag=0;
				
			}

			
		}
        transform.Translate(Vector2.right * velocity * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, flag, 0);
		//}
	// correct//	transform.Translate(Vector2.right * 4f * Time.deltaTime );
		//transform.eulerAngles = new Vector3(0,180,0); // correct

		
	}

	
	


	void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		
		Gizmos.DrawLine (sightStart.position, sightEnd.position);
	}
}
