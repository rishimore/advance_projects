using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCurrency : MonoBehaviour {

	public static UserCurrency Instance;

	[SerializeField]
	int gold = 100;
	[SerializeField]
	int silver = 50;

	public void Awake()
	{
		if (Instance == null) {
			Instance = GetComponent<UserCurrency> ();
		} 
		else 
		{
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () 
	{
		Invoke ("ReduceCurrency", 5);	
	}

	void ReduceCurrency()
	{
		gold -= 50;
		silver -= 20;
	}

	public int GetGold()
	{
		return gold;
	}

	public int GetSilver()
	{
		return silver;
	}
}
