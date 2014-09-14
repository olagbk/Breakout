using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	public KeyCode moveLeft;
	public KeyCode moveRight;
	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveLeft)){
			rigidbody2D.velocity = new Vector2 (speed * -1f, 0f);

		}else if (Input.GetKey (moveRight)){
			rigidbody2D.velocity = new Vector2 (speed, 0f);

		}else{
			rigidbody2D.velocity = new Vector2 (0f, 0f);
		}
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0f);
	}
}
