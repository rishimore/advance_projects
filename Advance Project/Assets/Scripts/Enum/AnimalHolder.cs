using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalHolder : MonoBehaviour 
{
	public Animal[] animals;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < animals.Length; i++) 
		{
			if (animals [i].foodType == AnimalType.Veg) 
			{
				Debug.Log (animals [i].name + "eats veg");
			} 
			else if (animals [i].foodType == AnimalType.Veg_NonVeg) 
			{
				Debug.Log (animals [i].name + "eats veg as well as nonveg");
			} 
			else 
			{
				Debug.Log (animals [i].name + "eats nonveg");
			}
				
		}	
	}

}
