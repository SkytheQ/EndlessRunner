using UnityEngine;
using System.Collections;
/// <summary>
///  
/// </summary>
public class PlayerMovement : MonoBehaviour {
	public float RunSpeed = 0.06f;
	private float JumpSpeed = 7f;
	//private bool isFalling = false;
	public Rigidbody2D rb;
	[SerializeField] private Transform groundCheck;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		/*
		float run = Input.GetAxis ("Horizontal") * RunSpeed;
		run *= Time.deltaTime;
		transform.Translate (run, 0, 0);
		*/

		transform.Translate (RunSpeed, 0, 0);

		//float jump = Input.GetAxis ("Vertical") * JumpSpeed;
		//jump *= Time.deltaTime;
		//transform.Translate (0, jump, 0);
		//rb.AddForce (Vector3.up * jump, ForceMode.Impulse);

	}

	void FixedUpdate() {
        //Debug.Log (JumpSpeed);
        /*
		if (Input.GetKeyDown (KeyCode.W) && isFalling == false) {
			rb.AddForce (Vector3.up * JumpSpeed, ForceMode.VelocityChange);
		}
		isFalling = true;
		*/
        //Debug.Log (JumpSpeed);
        //Debug.DrawLine(transform.position, groundCheck.position);
        //Debug.Log ("Player position: " + transform.position);
        //Debug.Log ("ground position: " + groundCheck.position);
		bool linecast2d = Physics2D.Linecast(transform.position, groundCheck.position , 1 << LayerMask.NameToLayer("Platform"));
		if (linecast2d)
        {
			Debug.DrawLine(transform.position , groundCheck.position , Color.green, 0.5f, false);
            if (Input.GetKeyDown(KeyCode.W))
            {
				rb.AddForce(Vector3.up * JumpSpeed, ForceMode2D.Impulse);
            }	
        }
        else {
			Debug.DrawLine(transform.position , groundCheck.position , Color.red, 0.5f, false);
        }
	}

	/*

	void OnCollisionStay() {
		isFalling = false;
	}
	*/
}