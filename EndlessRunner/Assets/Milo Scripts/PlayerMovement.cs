using UnityEngine;
using System.Collections;
/// <summary>
///  
/// </summary>
public class PlayerMovement : MonoBehaviour {
	private float RunSpeed = 10f;
	private float JumpSpeed = 10f;
	public Rigidbody rb;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		float run = Input.GetAxis ("Horizontal") * RunSpeed;
		run *= Time.deltaTime;
		transform.Translate (run, 0, 0);

		float jump = Input.GetAxis ("Vertical") * JumpSpeed;
		jump *= Time.deltaTime;
		transform.Translate (0, jump, 0);
		rb.AddForce (Vector3.up * jump, ForceMode.Impulse);

	}
}