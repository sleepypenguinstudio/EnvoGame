using UnityEngine;
using System.Collections;
	
	public class newCollisAttrct : MonoBehaviour {
		
		public forGravaityAttracter attracter;
		public forGravaityAttracter attracter2;
		private Transform myTransform;
		public Collider one;
		public Collider two;
		
		// Use this for initialization
		void Start () {
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			GetComponent<Rigidbody>().useGravity = false;
			myTransform = transform;
		}
		
		// Update is called once per frame
		void OnTriggerEnter(Collider one)
		{
			attracter.Attract(myTransform);
		}
		
	}