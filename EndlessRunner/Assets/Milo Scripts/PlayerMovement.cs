using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float RunSpeed = 10f;
	private float JumpSpeed = 30f;
	private float maxJumpHeight = 1f;
	private bool jumped = false;

	private Rigidbody rb;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		float run = Input.GetAxis ("Horizontal") * RunSpeed;
		run *= Time.deltaTime;
		transform.Translate(run, 0, 0);

		if (transform.position.y >= maxJumpHeight) {
			return;
		} else {
			float jump = Input.GetAxisRaw ("Vertical") * JumpSpeed;
			rb.AddForce (Vector3.up * jump * Time.deltaTime, ForceMode.Impulse);
		}

	}
}
