using UnityEngine;
using System.Collections;

public class AirForce : MonoBehaviour {
	
	//float force = 1f;
	float force = 20;

	public void OnTriggerStay(Collider coll)
	{
		Vector3 fanForce = new Vector3(0,force,0);
		Rigidbody rb = coll.GetComponent<Rigidbody> ();

		Vector3 velocity = rb.velocity;
		//rb.AddForce(transform.up*force,ForceMode.Impulse);
		velocity += fanForce * Time.deltaTime; // dir = fan direction, ie. transform.up or whatever setup you have there
		rb.velocity = velocity;
	}
}
