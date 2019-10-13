using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour,Ivehicle
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Drive()
	{
		Debug.Log ("This is is a Car, Please sit in Driver seat");
	}

	public void FillPetrol()
	{
		Debug.Log ("I need 20 liter of petrol");
	}
}
