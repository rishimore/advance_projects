using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour 
{
	public float speed;

	// Update is called once per frame
	void Update () {
	    
		transform.Translate (new Vector3 ((Input.GetAxis ("Horizontal") * speed * Time.deltaTime), 0, (Input.GetAxis ("Vertical") * speed * Time.deltaTime)));
	}

	private void OnTriggerEnter(Collider other)
	{
		Ivehicle tempIv = other.GetComponent<Ivehicle> ();

		if (tempIv != null) 
		{
			tempIv.Drive ();
		}
	}
}
