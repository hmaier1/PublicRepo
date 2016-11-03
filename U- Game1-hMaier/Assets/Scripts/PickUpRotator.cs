using UnityEngine;
using System.Collections;

public class PickUpRotator : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3 (0.0f,30, 0.0f) * Time.deltaTime * 2);
	}
}
