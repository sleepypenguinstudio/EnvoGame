using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Debug = System.Diagnostics.Debug;
using DG.Tweening;
public class SceneManagment : MonoBehaviour
{


    [SerializeField] public float fadeTime;
    public Ease Ease;

    public List<GameObject> planets = new List<GameObject>();


    public Vector3 targetPosition;


    public CanvasGroup[] panels;
    public int currentPanel = 0;

     void Start()
    {
        
           // planets[0].transform.localScale = Vector3.zero;
       // planets[0].transform.DOScale(targetPosition, fadeTime).SetEase(Ease).Restart();

        
    }

    public void GoToPanel(int panelIndex)
    {
        if (panelIndex >= 0 && panelIndex < panels.Length)
        {

            foreach (var item in planets)
            {
                item.transform.localScale = Vector3.zero;
            }

            foreach (var item in planets)
            {

                item.transform.DOScale(targetPosition, fadeTime).SetEase(Ease).Restart();

            }
            panels[currentPanel].alpha = 0f;
            panels[currentPanel].interactable = false;
            panels[currentPanel].blocksRaycasts = false;
            currentPanel = panelIndex;
            panels[currentPanel].alpha = 1f;
            panels[currentPanel].interactable = true;
            panels[currentPanel].blocksRaycasts = true;
           

        }
    }


}

