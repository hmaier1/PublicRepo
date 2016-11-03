using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public Text restartText;

	void Start () 
	{

		restartText.text = "Restart(esc)";
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
    	{ SceneManager.LoadScene (0);	}
	}
}
