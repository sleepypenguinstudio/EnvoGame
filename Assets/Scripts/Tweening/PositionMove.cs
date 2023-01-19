
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PositionMove : MonoBehaviour { 


   public float fadeTime;
public Ease Ease;
    public Image image;
    public Vector3 targetPosition;





    void Start()
    {
        MovePosition();
    }

  public void MovePosition()
    {


        image.rectTransform.DOLocalMove(targetPosition, fadeTime).SetEase(Ease);
    }
}
