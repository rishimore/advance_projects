using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCart : MonoBehaviour,Ivehicle
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Drive()
	{
		Debug.Log ("This is bull cart, Please sit Anywhere");
	}

	public void FillPetrol()
	{
		Debug.Log ("I dont need petrol, but require bulls");
	}
}
