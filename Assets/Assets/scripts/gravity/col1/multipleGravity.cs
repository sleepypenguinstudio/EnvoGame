using UnityEngine;
using System.Collections;

public class multipleGravity : MonoBehaviour
{
	
	// Use this for initialization
	//public Transform player;
	
	
	public static int Flag = 1;
	public Transform Player;
	public Transform Camera;
	
	
	// Update is called once per frame
	
	void OnTriggerEnter(Collider c)
	{
		Debug.Log ("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
		//Camera.transform.rotation = Quaternion.AngleAxis(Player.eulerAngles.z, new Vector3(0,0,1));
		//if(w1==1) w1 = 2;
		if (this.gameObject.name == "col-12")
		{
			Flag = 2;
			//if (Flag == 1) Flag = 2;
			//else Flag = 1;
		}
		else if (this.gameObject.name == "col-21")
		{
			Flag = 1;
			//if (Flag == 1) Flag = 2;
			//else Flag = 1;
		}
		else if (this.gameObject.name == "col-13")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-31")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-14")
		{
			
			Flag = 4;
			
		}
		else if (this.gameObject.name == "col-41")
		{
			
			Flag = 1;
			
		}
		else if (this.gameObject.name == "col-51")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-15")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-61")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-16")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-17")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-71")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-18")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-81")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-91")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-19")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-101")
		{
			Flag = 1;
		}
		else if (this.gameObject.name == "col-110")
		{
			Flag = 10;
		}
		//planet 2 starts
		else if (this.gameObject.name == "col-23")
		{
			Flag = 3;
			
		}
		else if (this.gameObject.name == "col-32")
		{
			Flag = 2;
		}
		
		else if (this.gameObject.name == "col-24")
		{
			Flag = 4;
		}
		
		else if (this.gameObject.name == "col-42")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-25")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-52")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-26")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-62")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-27")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-72")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-28")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-82")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-92")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-29")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-102")
		{
			Flag = 2;
		}
		else if (this.gameObject.name == "col-210")
		{
			Flag = 10;
		}
		//planet 3
		else if (this.gameObject.name == "col-34")
		{
			Flag = 4;
			
		}
		else if (this.gameObject.name == "col-43")
		{
			// Debug.Log("aa");
			Flag = 3;
			
		}
		else if (this.gameObject.name == "col-53")
		{
			Flag = 3;
		}
		
		else if (this.gameObject.name == "col-35")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-63")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-36")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-37")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-73")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-38")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-83")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-93")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-39")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-103")
		{
			Flag = 3;
		}
		else if (this.gameObject.name == "col-310")
		{
			Flag = 10;
		}
		//planet 4
		else if (this.gameObject.name == "col-45")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-54")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-64")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-46")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-47")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-74")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-48")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-84")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-94")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-49")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-104")
		{
			Flag = 4;
		}
		else if (this.gameObject.name == "col-410")
		{
			Flag = 10;
		}
		//planet 5
		else if (this.gameObject.name == "col-65")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-56")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-57")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-75")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-58")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-85")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-95")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-59")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-105")
		{
			Flag = 5;
		}
		else if (this.gameObject.name == "col-510")
		{
			Flag = 10;
		}
		//planet 6
		else if (this.gameObject.name == "col-67")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-76")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-68")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-86")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-96")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-69")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-106")
		{
			Flag = 6;
		}
		else if (this.gameObject.name == "col-610")
		{
			Flag = 10;
		}
		//planet 7
		else if (this.gameObject.name == "col-78")
		{
			Flag = 8;
		}
		
		else if (this.gameObject.name == "col-87")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-97")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-79")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-107")
		{
			Flag = 7;
		}
		else if (this.gameObject.name == "col-710")
		{
			Flag = 10;
		}
		//planet 8
		else if (this.gameObject.name == "col-98")
		{
			Flag = 8;
		}
		else if (this.gameObject.name == "col-89")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-108")
		{
			Flag = 8;
		}
		else if (this.gameObject.name == "col-810")
		{
			Flag = 10;
		}
		//planet 9
		else if (this.gameObject.name == "col-109")
		{
			Flag = 9;
		}
		else if (this.gameObject.name == "col-910")
		{
			Flag = 10;
		}
	}
	
}
