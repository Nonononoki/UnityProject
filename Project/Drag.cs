using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

	private Rigidbody rb;
	private int dragSpeed = 2;

	//Offset beacuse Camara is tilted
	private float offsetX = -1.1f;
	private float offsetY =  0.5f;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}


	void OnMouseDrag()
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		mousePos.x += offsetX;
		mousePos.y += offsetY;
		mousePos.z = 0f;

		//transform.position = mousePos;
		rb.velocity = (mousePos - gameObject.transform.position) * dragSpeed;
	}

	void OnMouseUp()
	{
		rb.velocity = Vector3.zero;
	}
}
