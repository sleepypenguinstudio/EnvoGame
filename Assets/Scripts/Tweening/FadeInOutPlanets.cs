
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;


public class FadeInOutPlanets : MonoBehaviour
{



    [SerializeField] public float fadeTimeforFirstTween;
    [SerializeField] public float fadeTimeforLastTween;
    public Ease Ease;
    public Ease Ease2;

    public List<GameObject> planets = new List<GameObject>();

    public Vector3 firstPosition;
    public Vector3 lastPosition;


     void Start()
    {
        PlanetAnimations();
        

    }

    public void PlanetAnimations()
    {


        
            foreach (var item in planets)
            {
                item.transform.localScale = Vector3.zero;
            }

            foreach (var item in planets)
            {

            item.transform.DOScale(firstPosition, fadeTimeforFirstTween).SetEase(Ease).OnComplete(() =>
            {
                item.transform.DOScale(lastPosition, fadeTimeforLastTween).SetEase(Ease2);
            });
           

        }
        
       


    }
}
