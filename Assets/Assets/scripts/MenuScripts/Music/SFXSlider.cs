using UnityEngine;
using System.Collections;


[RequireComponent (typeof (BoxCollider))]
public class SFXSlider : MonoBehaviour {

	public Transform knob;
	public TextMesh textMesh;
	public string sliderName;

	public static float initialSliderPercent = 0.5f;
	public int[] valueRange;
	public int decimalPlaces;

	private Vector3 targetPos;
	private float sliderPercent;
	private float sliderDisplayValue;
	private float sliderLength;

	// Use this for initialization
	void Start () {
		sliderLength = GetComponent<BoxCollider> ().size.x ;
		sliderPercent = initialSliderPercent + 0.2f;

		targetPos = knob.position + Vector3.right * (sliderLength/-2 + sliderLength * sliderPercent);
		knob.position = targetPos;
	}
	
	// Update is called once per frame
	void Update () {
		knob.position = Vector3.Lerp (knob.position,targetPos,Time.deltaTime * 7 );

		sliderPercent = Mathf.Clamp01(((knob.localPosition.x + sliderLength / 2) / sliderLength)-.32f);
		sliderDisplayValue = Mathf.Lerp (valueRange[0],valueRange[1],sliderPercent);
		textMesh.text = sliderDisplayValue.ToString("F" + decimalPlaces);
	}

	void OnTouchStay(Vector3 point)
	{
		targetPos = new Vector3 (point.x,targetPos.y,targetPos.z);

	}

	public float GetSliderPercent()
	{
		return sliderPercent;
	}
}
