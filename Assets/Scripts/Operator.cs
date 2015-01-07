using UnityEngine;
using System.Collections;

public class Operator : MonoBehaviour {

	public Transform[] path;
	public float[] time;
	public bool[] smooth;
	
	public GameObject currentCamera;
	public GameObject nextCamera;

	private int currentPathIndex = 0;
	private float startTime = 0.0f;
	private Vector3 velocity = Vector3.zero;
	private float t = 0.0f;
	private float rate = 0.0f;
	private Vector3 startPos = Vector3.zero;
	private Quaternion startRot = Quaternion.identity;

	void Start () {
		if (path.Length <= 0) return;
		rate = 1.0f / time[0];
		startPos = transform.position;
		startRot = transform.rotation;
	}

	void Update () {
		t += Time.deltaTime * rate;

		if (smooth[currentPathIndex])
		{
			transform.position = Vector3.SmoothDamp(transform.position, path[currentPathIndex].position, ref velocity, time[currentPathIndex]);
			//transform.position = Vector3.Slerp(startPos, path[currentPathIndex].position, t);
			transform.rotation = Quaternion.Slerp(startRot, path[currentPathIndex].rotation, t);
		}
		else
		{
			transform.position = Vector3.Lerp(startPos, path[currentPathIndex].position, t);
			transform.rotation = Quaternion.Lerp(startRot, path[currentPathIndex].rotation, t);
		}

		if (Time.time > startTime + time[currentPathIndex] /*Vector3.Distance(transform.position, path[currentPathIndex].position) <= 0.001f*/)
		{
			currentPathIndex++;

			if (currentPathIndex > path.Length - 1)
			{
				currentCamera.camera.enabled = false;
				nextCamera.camera.enabled = true;
				nextCamera.SetActive(true);
				gameObject.SetActive(false);
				return;
			}

			rate = 1.0f / time[currentPathIndex];
			t = 0.0f;
			startPos = transform.position;
			startRot = transform.rotation;
			startTime = Time.time;
		}
	}
}