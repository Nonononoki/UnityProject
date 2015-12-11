using UnityEngine;
using System.Collections;

public class AirForce : MonoBehaviour {
	
	//float force = 1f;
	public float force;

	public bool up = false;
	public bool down = false;
	public bool left = false;
	public bool right = false;

	Vector3 fanForce;

	void Start()
	{
		Debug.Log (this.name);
	}

	public void direction()
	{
		if (up) {
			fanForce = new Vector3 (0, force, 0);
		}
		else if (down) {
			fanForce = new Vector3 (0, -force, 0);
		}
		else if (right) {
			fanForce = new Vector3 (force, 0, 0);
		}
		else if (left) {
			fanForce = new Vector3 (-force, 0, 0);
		}

	}

	public void OnTriggerStay(Collider coll)
	{
		Debug.Log (this.enabled);
		if (this.enabled == true) {
			Rigidbody rb = coll.GetComponent<Rigidbody> ();

			direction ();

			Vector3 velocity = rb.velocity;

			velocity += fanForce * Time.deltaTime;
			rb.velocity = velocity;
		}
	}
}
