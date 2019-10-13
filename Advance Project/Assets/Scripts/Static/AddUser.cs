using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Static.health = 2;
		Debug.Log (Static.health);
	
		Static.myInt = 1;
		Debug.Log (Static.myInt);

		transform.position = Static.SetPositionToZero ();

	//	Debug.Log (Static.Instance.NonStaticFunc ());
	}

	// Update is called once per frame
	void Update () {
	
	}
}
