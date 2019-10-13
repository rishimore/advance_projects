using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {


	public Transform[] moveSpot;
	private int randomSpot;

	Transform player;

	UnityEngine.AI.NavMeshAgent nav;


	void Awake ()
	{
	//	player = GameObject.FindGameObjectWithTag ("Player").transform;
			
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();		
	}

	void Start() 
	{
	//	waitTime = startWaitTime;
		randomSpot = Random.Range (0, moveSpot.Length);
		StartCoroutine (RandomSpwanPosition());
	}

	void Update() 
	{
	//	RandomSpwanPosition ();
	}

	IEnumerator RandomSpwanPosition()
	{
		//transform.position = Vector3.MoveTowards (transform.position, moveSpot [randomSpot].position, speed * Time.deltaTime);
		nav.SetDestination (moveSpot [randomSpot].position);

		yield return new WaitForSeconds (2.0f);

		while (true) 
		{
			if ( nav.remainingDistance < 2.0f) {
				randomSpot = Random.Range (0, moveSpot.Length);	
				nav.SetDestination (moveSpot [randomSpot].position);
			}
			yield return new WaitForSeconds (1.0f);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") 
		{
			StopAllCoroutines ();
			player = other.gameObject.transform;
			StartCoroutine(FollowPetrol());
		}
	} 

	IEnumerator FollowPetrol()
	{
		while (player != null) 
		{
			nav.SetDestination (player.position);

			yield return new WaitForSeconds (1.0f);
		}
	}

}
