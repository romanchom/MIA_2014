using UnityEngine;
using System.Collections;

public class DelayFire : MonoBehaviour {
	public Animation anim;
	public float delay;
	void Start() {
		StartCoroutine(Fire());
	}

	IEnumerator Fire() {
		yield return new WaitForSeconds(delay - Time.time);
		anim.Play();
	}
}
