using UnityEngine;
using System.Collections;

public class DelayTrigger : MonoBehaviour {
	public Animator anim;
	public float delay;
	public string name;
	void Start() {
		StartCoroutine(Fire());
	}

	IEnumerator Fire() {
		yield return new WaitForSeconds(delay - Time.time);
		anim.SetTrigger(name);
	}
}
