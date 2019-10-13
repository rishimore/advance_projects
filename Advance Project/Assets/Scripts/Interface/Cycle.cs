using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour, Ivehicle 
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Drive()
	{
		Debug.Log ("This is cycle, Please sit on Seat"); 
	}

	public void FillPetrol()
	{
		Debug.Log ("I dont need Petrol");
	}
}
