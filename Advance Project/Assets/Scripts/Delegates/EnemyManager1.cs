using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager1 : MonoBehaviour {

	public Transform[] moveSpot;
	private int randomSpot;

	Transform player;

	UnityEngine.AI.NavMeshAgent nav;

	private void OnEnable()
	{
		GameManager.startGame += GameStarted;	
		GameManager.destroyObject += DestroyObject;
	}

	void Awake()
	{
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	// Use this for initialization
	void Start () 
	{
		randomSpot = Random.Range (0, moveSpot.Length);
		StartCoroutine (RandomSpwanPosition());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void GameStarted()
	{
		Debug.Log ("Spwaning Enemy");
	}

	private void OnDisable()
	{
		
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

	void OnTriggerEnter(Collider other)
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

	public void DestroyObject()
	{
		Destroy (gameObject, Random.Range(0,5));
	}

}
