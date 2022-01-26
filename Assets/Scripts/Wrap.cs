using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    private Camera cam;
    private float leftConstant;
    private float rightConstant;
    private float topConstant;
    private float bottomConstant;
    float buffer = 0.1f;
    
    void Start()
    {
        cam = Camera.main;
        rightConstant = cam.ScreenToWorldPoint(new Vector3(0, 0, cam.transform.position.z)).x;
        leftConstant = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, cam.transform.position.z)).x;
        bottomConstant = cam.ScreenToWorldPoint(new Vector3(0, 0, cam.transform.position.z)).y;
        topConstant = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, cam.transform.position.z)).y;
        // print("right: " + rightConstant);
        // print("left: " + leftConstant);
        // print( transform.position.y );

    }

    
    void FixedUpdate()
    {
        if (transform.position.y > topConstant) {
            transform.position = new Vector3(
                transform.position.x,
                bottomConstant + buffer,
                transform.position.z
                );
        }
        else if (transform.position.y < bottomConstant) {
            transform.position = new Vector3(
                transform.position.x,
                topConstant - buffer,
                transform.position.z
                );
        }
        if (transform.position.x > leftConstant) {
            transform.position = new Vector3(
                rightConstant + buffer,
                transform.position.y,
                transform.position.z
                );
        }
        else if (transform.position.x < rightConstant) {
            transform.position = new Vector3(
                leftConstant - buffer,
                transform.position.y,
                transform.position.z
                );
        }        
    }
}
