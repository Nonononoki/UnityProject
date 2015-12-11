using UnityEngine;
using System.Collections;

public class PropellerRotate : MonoBehaviour {

	float rs = 40;

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, rs * Time.deltaTime);
	}
}
