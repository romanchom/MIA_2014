using UnityEngine;
using System.Collections;

public class TakesManager : MonoBehaviour {
    public Take[] takes;
    int currentTakeID;

    private static TakesManager instance;
    public static TakesManager Instance
    {
        get
        {
            return instance;
        }
    }

	// Use this for initialization
	void Start () {
        instance = this;
        currentTakeID = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextTake()
    {
        takes[currentTakeID].gameObject.SetActive(false);
        currentTakeID++;
        takes[currentTakeID].gameObject.SetActive(true);
    }
}
