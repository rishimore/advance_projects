using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsEvents : MonoBehaviour {

	// Use this for initialization
	private void OnEnable() {
		PlayerEvents.helpMeEvent += Helping; 
	}

	private void Helping(Vector3 pos)
	{
		Debug.Log ("Helping my friends coming to pos" +pos);
		transform.position = pos;
	}
}
