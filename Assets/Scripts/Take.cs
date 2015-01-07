using UnityEngine;
using System.Collections;

public class Take : MonoBehaviour {



	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextTake()
    {
        TakesManager.Instance.NextTake();
    }
}
