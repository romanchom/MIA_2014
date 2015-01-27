using UnityEngine;
using System.Collections;

public class Take02Events : MonoBehaviour {

    [SerializeField]
    GameObject firstChar;

    [SerializeField]
    GameObject secondChar;

    [SerializeField]
    BubbleScript bubble;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void StandUpZabijMnieSmiechem()
    {
        firstChar.SetActive(false);
        secondChar.SetActive(true);
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
