using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerEvents : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.N)) 
		{
	//	  	PlayerEvents.helpMeEvent = null;
		}

		if (Input.GetKeyDown (KeyCode.F)) 
		{
	//		PlayerEvents.helpMeEvent = Attack;
		}
	}

	private void Attack(Vector3 pos)
	{
	//	Player.helpMeEvent = Attack;
	}
}
