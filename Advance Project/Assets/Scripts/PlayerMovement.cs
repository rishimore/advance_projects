using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int speed;
	public int rotation;

	public Transform spawnPoint;

	public GameObject shot;

	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, -rotation * Time.deltaTime, 0);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, rotation * Time.deltaTime, 0);
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -speed * Time.deltaTime);
		}

		if (Input.GetButton ("Fire1")) {
			Instantiate (shot, spawnPoint.position, spawnPoint.rotation);
		}


	}
}
