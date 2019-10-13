using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	void Start () {
		//	healthText.text = "Health:" + health;
	}

	public void ReduceHealth(int damage){
		health = health - damage;
		//	healthText.text = "Health:" + health;
		if (health<=0)
		{
			Destroy (gameObject);
		}
	}
}
