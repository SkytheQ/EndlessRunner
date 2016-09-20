using UnityEngine;
using System.Collections;

public class playerMovement2 : MonoBehaviour {

    private float RunSpeed = 5f;
    private float JumpSpeed = 10f;
    public Rigidbody2D rb;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float run = Input.GetAxis("Horizontal") * RunSpeed;
        run *= Time.deltaTime;
        transform.Translate(run, 0, 0);

        float jump = Input.GetAxis("Vertical") * JumpSpeed;
        jump *= Time.deltaTime;
        transform.Translate(0, jump, 0);
        rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);

    }
}
