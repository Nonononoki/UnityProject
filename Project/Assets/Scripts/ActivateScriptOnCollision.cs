using UnityEngine;
using System.Collections;

public class ActivateScriptOnCollision : MonoBehaviour {

	public float collisionVelocity = 6f;
	public MonoBehaviour mb;

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.relativeVelocity.magnitude > collisionVelocity)
		{			
			mb.enabled = true;
		}
	}
}
