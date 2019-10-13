using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed;

	public Rigidbody rb;

//	bool playerCanMove = false;

	bool paused = false;

	private void OnEnable()
	{
		GameManager.startGame += GameStarted;
		GameManager.pauseGame += GamePause;
		GameManager.destroyObject += DestroyObject;
		GameManager.helpMenu += HelpMenu;
	}

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();

	}

	// Use this for initialization
	void Start () 
	{
//		playerCanMove = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void GameStarted()
	{
		Debug.Log ("Game started player can move now");
	}

	// Update is called once per frame
	void FixedUpdate () 
	{

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Vector3 movement = new Vector3 (h, 0, v);

		rb.velocity = movement.normalized * speed;
	}

	public void GamePause()
	{
		paused = !paused;

		if (paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}

	public void DestroyObject()
	{
		Destroy (gameObject, 2);
	}

	public void HelpMenu()
	{
		Debug.Log ("i need some help");	
	}

	private void OnDisable()
	{
		
	}
		
}
