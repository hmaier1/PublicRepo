using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player2Controller : MonoBehaviour {

	public float speed;
	public Text countText2;
	public Text winText;
	public Text restartText;

	private Transform respawnPosition;
	private Rigidbody rb;
	private bool health;
	private float count2;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();

		health = true;

		winText.text ="";
		restartText.text = "";
		SetCountText();
	}

	void FixedUpdate ()
	{
		//controlled by arrow keys 
		float moveHorizontal = Input.GetAxis ("p2_Horizontal");
		float moveVertical = Input.GetAxis ("p2_Vertical");

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
    		count2 = count2 + 1;
			SetCountText ();
    	}
		else if (other.gameObject.CompareTag("enemy"))
		{	
    		health = false;
    		if (health == false)
    		{
				transform.position = new Vector3 (0f, 0.5f, 0);
       			rb.velocity = Vector3.zero;
       			rb.angularVelocity = Vector3.zero;
    		}
    	}
    }
    void SetCountText()
    {
    	countText2.text = "Count: " + count2.ToString ();
		if (count2 > 9)
    	{
    		winText.text = "Player 2 Wins!"; 
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
