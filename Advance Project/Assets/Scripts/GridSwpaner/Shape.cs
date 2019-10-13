using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ShapeType : int {Cube, Sphere, Capsule, Cylinder};

[System.Serializable]
public enum ShapeColor : int {Red, Green, Blue, Yellow};


public class Shape : MonoBehaviour  
{
	public ShapeType type;
	public ShapeColor color;

	void Start()
	{
	//	Destroy (gameObject, lifeTime);
	}
}
	

