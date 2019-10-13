using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	
	public GameObject player;
	public GameObject enemy;

	public Transform spwanPoint;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemy());
	}
	
	// Update is called once per frame
	IEnumerator SpawnEnemy() {

		int i = 0;
		while (i < 5) 
		{
			yield return new WaitForSeconds (5.0f);
			GameObject temp = Instantiate (enemy, spwanPoint.position, spwanPoint.rotation);
			temp.GetComponent <EnemyMovments> ();
			i++;
		}
	}
}
