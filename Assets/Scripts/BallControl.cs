using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	public Transform paddle;

	// Use this for initialization
	void Start () {
		transform.position = (new Vector2 (0f, 0f));
		rigidbody2D.AddForce (new Vector2 (0f, -30f));
	}
	

	void OnCollisionEnter2D (Collision2D collisionInfo) {

		if (collisionInfo.gameObject.tag == "Player") {
			ContactPoint2D myCP = collisionInfo.contacts[0];
			float contact = (myCP.point.x - paddle.position.x) / 1.25f;
			float velocityX = rigidbody2D.velocity.x;
			float desiredX = (velocityX + (contact * 5f));
		
			rigidbody2D.velocity = new Vector2 (desiredX, rigidbody2D.velocity.y);	


		
		}
		float maxMag = 10;
		if (rigidbody2D.velocity.magnitude > maxMag) {
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxMag;		
		}
		Debug.Log (rigidbody2D.velocity.magnitude);
	}
}
