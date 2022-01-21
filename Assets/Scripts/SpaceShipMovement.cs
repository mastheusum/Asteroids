using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0) {
            rig.AddForce(transform.up * impulse, ForceMode2D.Impulse);
        }
        rig.AddTorque(rotateSpeed * rig.inertia * Input.GetAxis("Horizontal"), ForceMode2D.Impulse);
    }
}
