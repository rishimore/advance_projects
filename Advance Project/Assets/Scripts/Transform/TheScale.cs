using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (1, 1, Random.Range (0.1f, 5.0f));
	}
}
