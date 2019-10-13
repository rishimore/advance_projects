using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour {

//	public Text ValueTxt;

	// Use this for initialization
	private void Start () 
	{
//		ValueTxt.text = PersistentManagerScript.Instance.Value.ToString (); 
		Invoke("LoadScene", 7);
	}

	public void LoadScene()
	{
		SceneManager.LoadScene (1);
	}

/*	public void GoToFirstScene()
	{
		SceneManager.LoadScene ("Scence/SingleTone/first");
		PersistentManagerScript.Instance.Value++;
	}

	public void GoToSecondScene()
	{
		SceneManager.LoadScene ("Scence/SingleTone/second");
		PersistentManagerScript.Instance.Value++;
	}
	*/
}
