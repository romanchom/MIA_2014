using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class BubbleScript : MonoBehaviour {

    Animator bubbleAnimator;

    [SerializeField]
    List<Sprite> emoticons;

    [SerializeField]
    Image iconImage;

   // public Vector3 lookAtTarget = Vector3.zero;

	// Use this for initialization
	void Start () {
        bubbleAnimator = GetComponentInChildren<Animator>();
	}

    void Update()
    {
        
    }

    public void Show()
    {
        //transform.LookAt(lookAtTarget);
        //transform.Rotate(0, 90, 0);
        iconImage.sprite = emoticons[0];
        emoticons.RemoveAt(0);
        bubbleAnimator.SetTrigger("Show");
    }

    public void Hide()
    {
        bubbleAnimator.SetTrigger("Hide");
    }

    

}
