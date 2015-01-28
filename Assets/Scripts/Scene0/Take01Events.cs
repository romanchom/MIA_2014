using UnityEngine;
using System.Collections;

public class Take01Events : MonoBehaviour {

    [SerializeField]
    GameObject cupOnBoard;

    [SerializeField]
    GameObject cupInHand;

    [SerializeField]
    Transform offsetCharacterPosition;

    [SerializeField]
    GameObject mainCharacter;

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
        PositionCorrection();
        //Debug.Log("position corrected");
    }

    void PositionCorrection()
    {
        mainCharacter.transform.position = offsetCharacterPosition.position;
    }

    void GrabNewspaper()
    {
        mainCharacter.GetComponentInChildren<Animator>().SetTrigger("newsPaper");
    }
}
