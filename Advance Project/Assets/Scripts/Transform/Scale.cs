using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (Random.Range (0.2f, 3.0f), 1, Random.Range (0.2f, 3.0f));
	}
}
