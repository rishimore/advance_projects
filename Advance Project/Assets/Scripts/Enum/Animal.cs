using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum AnimalType : int {Veg, Veg_NonVeg, NonVeg};

[System.Serializable]
public enum AnimalName : int {Cat, Dog, Cow, Goat, Tiger, Lion};

[System.Serializable]
public struct Animal 
{
	public AnimalName name;
	public AnimalType foodType;
}
