using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpHeight;
	
	private float rightButtonPosition = Screen.width /2 + Screen.width /4;
	private float leftButtonPosition = Screen.width / 4;
	
	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{		
		//jump right
		if (Input.touchCount > 0 && Input.GetTouch(0).tapCount == 2 && Input.GetTouch(0).position.x > rightButtonPosition)
		{
			jump(true);
		}
		
		//jump left
		if(Input.touchCount > 0 &&Input.GetTouch(0).tapCount == 2 && Input.GetTouch(0).position.x < leftButtonPosition)
		{
			jump(false);
		}

		//move right
		if(Input.touchCount > 0 /*&& Input.GetTouch(0).tapCount == 1*/ && Input.GetTouch(0).position.x > rightButtonPosition)
		{	
			move(true);
		}
		//move left
		if (Input.touchCount > 0 /*&& Input.GetTouch(0).tapCount == 1*/ && Input.GetTouch(0).position.x < leftButtonPosition)
		{
			move(false);
		}

		PCTest ();
	}

	void move(bool right)
	{
		if (right) {
			transform.position += transform.right * moveSpeed * Time.deltaTime;

		} else if(!right){
			transform.position -= transform.right * moveSpeed * Time.deltaTime;
		}
	}

	void jump(bool right)
	{
		if (right && !isJumping()) 
		{
			rb.AddForce(transform.up*jumpHeight,ForceMode.Impulse);

		} else if (!right && !isJumping()) {
			rb.AddForce(transform.up*jumpHeight,ForceMode.Impulse);
		}
	}

	bool isJumping()
	{
		if (rb.velocity.y == 0 && rb.velocity.z == 0)
			return false;
		else 
			return true;

	}

	void PCTest()
	{
		if (Input.GetKey ("up")) {
			jump (true);
		}
		if (Input.GetKey ("down")) {
			jump (false);
		}
		if(Input.GetKey("left")){
			move (false);
		}
		if(Input.GetKey("right")){
			move (true);
		}
	}
}
