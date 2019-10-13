using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour {

	public Vector3 spwanPoint = new Vector3 (-20f, 1f, 20f);
	public GameObject[] shapes;

	void Start()
	{
		for (int i = 0; i <= 5; i++) 
		{
			spwanPoint.x = -20f;
			for (int j = 1; j <= 5; j++) {
				GameObject temp = Instantiate (shapes [Random.Range (0, shapes.Length)], spwanPoint, Quaternion.identity);
				spwanPoint.x += 10f;
			}
			spwanPoint.z -= 10f;
		}

	}
}
