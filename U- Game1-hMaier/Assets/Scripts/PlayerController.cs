using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public float restartCount;
	public Text countText;
	public Text winText;
	public Text overText;
	public Text restartText;

	private Transform respawnPosition;
	private Rigidbody rb;
	private int count;
	private bool health;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();

		health = true;

		count = 0;
		winText.text ="";
		overText.text = "";
		restartText.text = "";
		SetCountText();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
     	if(other.gameObject.CompareTag ("spawn"))
       	{
       		transform.position = new Vector3 (0f, 0.5f, 0);
       		rb.velocity = Vector3.zero;
       		rb.angularVelocity = Vector3.zero;
       	}
     	else if (other.gameObject.CompareTag("Pick Up"))
      	{
    		other.gameObject.SetActive (false);
    		count = count + 1;
			SetCountText ();
    	}
		else if (other.gameObject.CompareTag("enemy") && count != 11)
		{	
    		health = false;
    		if (health == false)
    		{
				Time.timeScale = 0;
    			overText.text = "Game Over!";
    			restartText.text = "Press enter to restart.";
    		}
    	}
    }
    void SetCountText()
    {
    	countText.text = "Count: " + count.ToString ();
    	if (count == 11)
    	{
    		winText.text = "You Win!"; 
    		restartText.text = "Press enter to restart.";
    	}
    }
    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Return))
    	{
			SceneManager.LoadScene (0);
			Time.timeScale = 1;
    	}
    }

}
	