using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SceneManager : MonoBehaviour
{


    public Stack<GameObject> panelStack = new Stack<GameObject>();


    

    public void PushPanel(GameObject panel)
    {
        if (panelStack.Count > 0)
        {
            panelStack.Peek().SetActive(false);
        }
        panelStack.Push(panel);
        panel.SetActive(true);
     
    }

    public void PopPanel ()
    {
        if (panelStack.Count > 0)
        {
            GameObject previousPanel = panelStack.Pop();
            previousPanel.SetActive(false);
            if (panelStack.Count > 0)
            {
                panelStack.Peek().SetActive(true);
            }
        }
    }





}

