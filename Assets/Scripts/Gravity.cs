using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private float curSpeed = 1.0f;
    private float acceleration = 2f;
    private float maxSpeed = 7.0f;
    Rigidbody2D myRb;

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        myRb.velocity = Vector3.down * curSpeed;

        curSpeed += acceleration;

        if (curSpeed > maxSpeed)
        {
            curSpeed = maxSpeed;
        }

    }
}
