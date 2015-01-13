using UnityEngine;
using System.Collections;

public class Take01Events : MonoBehaviour {

    [SerializeField]
    GameObject cupOnBoard;

    [SerializeField]
    GameObject cupInHand;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void PutDownCup()
    {
        Destroy(cupInHand);
        cupOnBoard.SetActive(true);
    }
}
