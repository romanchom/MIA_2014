using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    [SerializeField]
    Text countdownText;
    float ttl = 5;

    [SerializeField]
    Animator[] aniamators;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        ttl -= Time.deltaTime;

        if (ttl <= 0)
        {
            countdownText.gameObject.SetActive(false);

            foreach (Animator item in aniamators)
            {
                item.enabled = true;
            }
            
        }
        else
        {
            countdownText.text = ((int)ttl).ToString();
        }
        
	}
}
