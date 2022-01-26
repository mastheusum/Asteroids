using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpaceShipMovement : MonoBehaviour
{
    public float impulse = .2f;
    public float rotateSpeed = 2;
    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") > 0) {
            rig.AddForce(transform.up * impulse, ForceMode2D.Impulse);
        }
        if ( Math.Abs(rig.angularVelocity) < 60 )
            rig.AddTorque(rotateSpeed * rig.inertia * (-Input.GetAxisRaw("Horizontal")) * Time.deltaTime, ForceMode2D.Impulse);
    }
}
