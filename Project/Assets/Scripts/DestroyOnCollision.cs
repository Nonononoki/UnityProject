using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

	public GameObject go;
	public float collisionVelocity = 6f;

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.relativeVelocity.magnitude > collisionVelocity)
		{
			Destroy(go);
		}
	}
}
