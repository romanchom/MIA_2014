using UnityEngine;
using System.Collections;

public class Take0Events : MonoBehaviour {

	[SerializeField]
	GameObject guard;

	[SerializeField]
	BubbleScript bubble;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Hit()
	{
		guard.GetComponentInChildren<Animator>().SetTrigger("Hit");
	}

	void ShowBubble()
	{
		//bubble.lookAtTarget = this.transform.position;
		bubble.Show();
	}
	
	void HideBubble()
	{
		bubble.Hide();
	}
}
