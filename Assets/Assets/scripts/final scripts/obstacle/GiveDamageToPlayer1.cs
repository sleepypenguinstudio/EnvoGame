using UnityEngine;
class GiveDamageToPlayer2: MonoBehaviour
{
    public GameObject lifeStar1;
    public GameObject lifeStar2;
    public GameObject lifeStar3;

    public static int life = 3;

    public void Start()
    {
        lifeStar1.SetActive(true);
        lifeStar2.SetActive(true);
        lifeStar3.SetActive(true);
        life = 3;
    }
    public void Update()
    {

        if (life == 3)
        {
            lifeStar1.SetActive(true);
            lifeStar2.SetActive(true);
            lifeStar3.SetActive(true);
        }
        else if (life == 2)
        {
            lifeStar1.SetActive(false);

        }
        else if (life == 1)
        {
            lifeStar1.SetActive(false);
            lifeStar2.SetActive(false);
        }
        else if (life == 0)
        {
            lifeStar1.SetActive(false);
            lifeStar2.SetActive(false);
            lifeStar3.SetActive(false);
            Application.LoadLevel(0);
            multipleGravity.Flag = 1;
            StaticFlag.TotalOx = 0;

        }

    }
    void OnCollisionEnter(Collision other1)
    {
        //Debug.Log("sadas");

        if (other1.gameObject.name == "Player")
        {
             Debug.Log("sad");  
			GetComponent<AudioSource>().Play();
            life = life - 1;
        }

    }
}