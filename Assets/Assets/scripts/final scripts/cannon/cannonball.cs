using UnityEngine;
using System.Collections;

public class cannonball : MonoBehaviour
{


    public forGravaityAttracter attracterp;
    //public forGravaityAttracter attracter2;
    //public multipleGravity amg;
    private Transform myTransform1;
    public Vector3 CannonStart;
	public Transform CannonPos;

    //public Transform player;
//    float distancefrom_player;
//    public float look_range = 20.0f;
//    public float agro_range = 10.0f;
//    public float move_speed = 5.0f;
//    public float damping = 6.0f;
    // public Transform sightStart1;
    //public Transform sightEnd1;
    //  public LayerMask detectWhat1;
   // private int flag = 180;
    // public GameObject cannon;
    //  public bool colliding1;

    public float velocity = 1f;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform1 = transform;

        //  colliding1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        attracterp.Attract(myTransform1);
        //
        //  colliding1 = Physics.Linecast(sightStart1.position, sightEnd1.position, detectWhat1);


        //if (colliding1)
        //{

        //    //transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
        //    //velocity*= -1;

        //    //GameObject.Destroy(gameObject,0.1f);

        //}

        transform.Translate(Vector2.right * 4f * Time.deltaTime);

    }




    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cannon" )
        {

			CannonStart = CannonPos.transform.position;
           // Debug.Log("sad");
          //  Destroy(gameObject, .01f);
			gameObject.SetActive(false);
			gameObject.transform.position = CannonStart;
			gameObject.SetActive(true);
           // Instantiate(gameObject, new Vector3( CannonStart.transform.position.x , CannonStart.transform.position.y, 0), Quaternion.identity);
        }
		if (col.gameObject.name == "Player") {
			CannonStart = CannonPos.transform.position;
			GiveDamageToPlayer.life=GiveDamageToPlayer.life-1; //kill the player at one blow
			gameObject.SetActive(false);
			gameObject.transform.position = CannonStart;
			gameObject.SetActive(true);
			//Instantiate(gameObject, new Vector3( CannonStart.transform.position.x , CannonStart.transform.position.y, 0), Quaternion.identity);
		
		}
    }

}
