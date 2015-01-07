using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawSphere(transform.position, 0.1f);
	}

}
