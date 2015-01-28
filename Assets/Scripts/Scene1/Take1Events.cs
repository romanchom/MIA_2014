using UnityEngine;
using System.Collections;

public class Take1Events : MonoBehaviour {

	[SerializeField]
	GameObject main;

	[SerializeField]
	GameObject ceiling;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void HideCeiling()
	{
		ceiling.SetActive(false);
	}

	void Play()
	{
		main.GetComponentInChildren<Animator>().SetTrigger("Play");
	}

}
