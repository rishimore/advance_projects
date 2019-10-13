using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

	public Gun Currentgun;

	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;

	public Transform raySpwanPoint;

	public LayerMask layerMask;

	void Start()
	{
	
	}

	void Update()
	{
	
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		transform.Translate (0, rotation, 0);

		if (Input.GetKeyDown ("space")) {
		   
			DoRayCast ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			ClickRayCast ();
		}
	}

	public void DoRayCast(){

		RaycastHit hit;

		if (Physics.Raycast (raySpwanPoint.position, raySpwanPoint.TransformDirection (Vector3.forward), out hit, Mathf.Infinity, layerMask)) 
		{  
			Debug.DrawRay (raySpwanPoint.position, raySpwanPoint.TransformDirection (Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log ("Did Hit " + hit.collider.gameObject.name);
		} 
		else 
		{
			Debug.DrawRay (raySpwanPoint.position, raySpwanPoint.TransformDirection (Vector3.forward) * 1000, Color.white);
			Debug.Log ("Did not Hit");
		}

	}

	void ClickRayCast()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100)) {
			Debug.DrawLine (ray.origin, hit.point);

			Destroy (hit.collider.gameObject);
		}
	}

	public void ChangeGun(Gun newGun) 
	{
		Currentgun = newGun;
	}
}
