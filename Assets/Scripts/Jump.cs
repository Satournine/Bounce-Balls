using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool grounded = true;
    Rigidbody ball;
    Vector3 jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        jumpForce = new Vector3(0, 200f, 0);
    }

    // Update is called once per frame

    public void ballJumper() //Adds upwards force to ball.
    {
        if (grounded)
        {
            ball.AddForce(jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision) // To prevent double jump, check if ball is on the ground.
    {
        grounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
