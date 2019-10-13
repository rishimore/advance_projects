using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPick : MonoBehaviour {

	public GameObject groundGun;
	public GameObject playerGun;

	// Use this for initialization
	void Start () {
		playerGun.SetActive (false);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			playerGun.SetActive (true);
			groundGun.SetActive (false);
		}

	}

}
