using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour {

	public static Static Instance;

	public static float health;

	public static int myInt;

	void Start()
	{
		health = 3;
		Debug.Log (health);
	}

	public static Vector3 SetPositionToZero()
	{
		return Vector3.zero;
	}

	public void NonStaticFunc()
	{
		Debug.Log ("i am not static function");
	}

}
