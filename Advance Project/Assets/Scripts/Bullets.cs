using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {

	int damage  = 10;
//	public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Rigidbody>().velocity = transform.forward * speed;
		transform.Translate (0, 0, -50 * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		Debug.Log (other.tag);
		if (other.gameObject.CompareTag ("Enemy")) {
			other.GetComponent<Enemy> ().ReduceHealth (damage); 
		}
		Destroy (gameObject);
	}
}
