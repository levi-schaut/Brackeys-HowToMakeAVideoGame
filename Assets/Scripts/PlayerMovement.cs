using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private bool isMovingLeft = false;
    private bool isMovingRight = true;

    // Update is called once every frame
    private void Update() 
    {
        if (Input.GetKey("a")) {
            isMovingLeft = true;
        } else {
            isMovingLeft = false;
        }
        if (Input.GetKey("d")) {
            isMovingRight = true;
        }
        else {
            isMovingRight = false;
        }
    }

    // FixedUpdate is for making regular physics calculations
    void FixedUpdate()
    {
        if (transform.position.y > -1f) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (isMovingLeft) {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (isMovingRight) {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        } else {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
