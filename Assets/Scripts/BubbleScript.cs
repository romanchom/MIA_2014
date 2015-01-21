using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {

    Animator bubbleAnimator;

	// Use this for initialization
	void Start () {
        bubbleAnimator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp("q"))
        {
            ShowBubble();
        }
        else if (Input.GetKeyUp("w"))
        {
            HideBubble();
        }
	}

    public void ShowBubble()
    {
        bubbleAnimator.SetTrigger("Show");
    }

    public void HideBubble()
    {
        bubbleAnimator.SetTrigger("Hide");
    }

}
