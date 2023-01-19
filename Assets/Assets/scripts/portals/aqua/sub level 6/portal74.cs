using UnityEngine;
using System.Collections;

public class portal74 : MonoBehaviour {


    public Transform PlayerNewPos; // for portal
    // public Transform PlayerOldPos; // for portal
    public Vector3 portalPos;
    public Transform Camera; //for camera following
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.z, new Vector3(0, 0, 1));
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "aqua portal in7")
        {
            Camera.transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.z, new Vector3(0, 0, 1));
            portalPos = PlayerNewPos.transform.position;

            if (multipleGravity.Flag == 7)
            {

                // gameObject.SetActive(false);
                gameObject.transform.position = portalPos;
                multipleGravity.Flag = 4;
                //  gameObject.SetActive(true);

            }

        }
    }
}
