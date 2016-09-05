using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public float speed;
    public Text countText;
    public Text winText;
    public Text moveText;
    public float distance;

	private Rigidbody rb;
    private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
		moveText.text = "Units Traveled: ";
    }

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, MoveVertical);

		distance += (Mathf.Abs(moveHorizontal) + Mathf.Abs(MoveVertical))/10;
		SetMoveText ();

		rb.AddForce (movement * speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win";
        }
    }
    void SetMoveText ()
    {
		if (distance >= 0.00f)
    	{
		moveText.text = "Units Traveled: " + distance.ToString("#.00");
		}
    }
  }
