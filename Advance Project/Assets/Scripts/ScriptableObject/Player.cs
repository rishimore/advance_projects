using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Gun Currentgun;

	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;

	public Transform spwanPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		//move translation along the object z`axis
		transform.Translate (0, 0, translation);

		//rotate around y-axis
		transform.Rotate (0, rotation, 0);

		if (Input.GetKeyDown ("space")) 
		{
			GameObject tempBullet = Instantiate (Currentgun.bullet, spwanPoint.position, spwanPoint.rotation);  
		}
	}

	public void ChangeGun(Gun newGun){
	   
		Currentgun = newGun;
		Debug.Log ("pick up new gun");
	}
}
