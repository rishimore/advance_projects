using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	public Gun pickUpGun;

	void OnTriggerEnter(Collider other){
		Player currentPlayer = other.gameObject.GetComponent<Player> ();
		if (currentPlayer != null) {
			currentPlayer.ChangeGun (pickUpGun);
		}
	}
}
