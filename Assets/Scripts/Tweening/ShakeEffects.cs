
using UnityEngine;
using DG.Tweening;

public class ShakeEffects : MonoBehaviour
{
    public Transform targetObject;
    public float shakeDuration = 1f;
    public float shakeStrength = 1f;
    public int shakeVibrato = 10;
    public float shakeRandomness = 90;

    void Start()
    {
        ShakeWarningSign();
    }



    public void ShakeWarningSign()
    {
        targetObject.DOShakePosition(shakeDuration, shakeStrength, shakeVibrato, shakeRandomness);
    }
}
