using UnityEngine;
using System.Collections;

public class Schalter : MonoBehaviour {

	public GameObject go;
	private float collisionVelocity = 6f;

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.relativeVelocity.magnitude > collisionVelocity)
		{
			Destroy(go);
		}
	}
}
