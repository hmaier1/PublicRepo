using UnityEngine;
using System.Collections;

public class LLaserScript : MonoBehaviour 
{	public Sprite laserOnSprite;
	public Sprite laserOffSprite;
	public float interval = 0.5f;
	public float rotationSpeed = 0.0f;
	private bool isLaserOn = true;
	private float timeUntilNextToggle;
	private Renderer rr;
	private Collider2D cd;

	void Start()
	{	timeUntilNextToggle = interval;
		rr = GetComponent<Renderer>();
		cd = GetComponent<Collider2D>();
	}
	void FixedUpdate()
	{	timeUntilNextToggle -= Time.fixedDeltaTime;

		if (timeUntilNextToggle <= 0)
		{	isLaserOn = !isLaserOn;
			cd.enabled = isLaserOn;

			SpriteRenderer spriteRenderer = ((SpriteRenderer)this.rr);
			if (isLaserOn)
				spriteRenderer.sprite = laserOnSprite;
			else 
				spriteRenderer.sprite = laserOffSprite;

				timeUntilNextToggle = interval;
		}

		transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time.fixedDeltaTime);
	}
}
