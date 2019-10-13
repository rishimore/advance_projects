using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunction : MonoBehaviour {

	public float moveSpeed = 0.1f;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
