using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObject : MonoBehaviour {

	public Bullet bulletData;


	void Update() {

		transform.Translate (0, 0, bulletData.speed * Time.deltaTime);
	}
		
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "bullet") {
			Destroy (GetComponent<Enemy> ());
		}
	}
}
