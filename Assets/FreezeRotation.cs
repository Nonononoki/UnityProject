using UnityEngine;
using System.Collections;

public class FreezeRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
	}
}
