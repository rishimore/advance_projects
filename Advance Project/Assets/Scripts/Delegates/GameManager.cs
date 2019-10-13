using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public delegate void StartGame ();
	public static StartGame startGame;

	public delegate void PauseGame ();
	public static PauseGame pauseGame;

	public delegate void DestroyObject ();
	public static DestroyObject destroyObject;

	public delegate void HelpMenu ();
	public static HelpMenu helpMenu;

	// Use this for initialization
	void Start () {

	}

	public void StartGameNow()
	{
		StartCoroutine (StartGameCoroutine());
		Invoke ("DelayCall",5);
		InvokeRepeating ("DelayCallRepeat", 5, 1);
	}

	IEnumerator StartGameCoroutine(){
		yield return new WaitForSeconds (3);	

		if (startGame != null) 
		{
		 	startGame ();
		}
	
	}

	void DelayCall(){
		Debug.Log ("DelayCall");
	}

	void DelayCallRepeat(){
		Debug.Log ("DelayCall repeat");
	}

	public void PauseGameNow()
	{
		if (pauseGame != null) 
		{
			pauseGame ();
		}
	}

	public void DestroyObjectsNow()
	{
		if (destroyObject != null) 
		{
			destroyObject ();
		}
	}

	public void HelpMenuNow()
	{
		if (helpMenu != null) 
		{
			helpMenu ();
		}
	}
		
}
