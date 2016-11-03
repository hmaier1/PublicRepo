using UnityEngine;
using System.Collections;

public class ParallaxScroll : MonoBehaviour 
{	public Renderer background;
	public Renderer foreground;
	public float backgroundSpeed = 0.02f;
	public float foregroundSpeed = 0.06f;
	public float offset = 0;

	void Update()
	{	float backroundOffset = offset * backgroundSpeed;
		float foreroundOffset = offset * foregroundSpeed;

		background.material.mainTextureOffset = new Vector2(backroundOffset, 0);
		foreground.material.mainTextureOffset = new Vector2(foreroundOffset, 0);

	}
}
