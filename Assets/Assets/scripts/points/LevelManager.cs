using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static LevelManager Instance { get; private set;}
	public Player Player { get; private set;}
	public CameraController Camera { get; private set;}
	// Use this for initialization

	public void Awake()
	{

	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void KillPlayer()
	{

	}

	private IEnumerator KillPayerCo()
	{
		yield break;
	}
}
