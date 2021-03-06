using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player1Controller : MonoBehaviour {

	public float speed;
	public Text countText1;
	public Text winText;
	public Text restartText;

	private Transform respawnPosition;
	private Rigidbody rb;
	private bool health;
	private float count1;

		void Start ()
	{
		rb = GetComponent<Rigidbody>();

		health = true;

		count1 = 0.0f;

		winText.text ="";
		restartText.text = "";
		SetCountText();
	}

	void FixedUpdate ()
	{
		//controlled by wasd
		float moveHorizontal = Input.GetAxis ("p1_Horizontal");
		float moveVertical = Input.GetAxis ("p1_Vertical");

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
    		count1 = count1 + 1;
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
    	countText1.text = "Count: " + count1.ToString ();
		if (count1 > 9)
    	{
    		winText.text = "Player 1 Wins"; 
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
	
