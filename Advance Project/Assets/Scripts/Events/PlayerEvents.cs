using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvents : MonoBehaviour {

	public delegate void HelpMe (Vector3 pos);

	public static event HelpMe helpMeEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (helpMeEvent != null) 
			{
				helpMeEvent (Vector3.zero);
			}
		}
	}
}
