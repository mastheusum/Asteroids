using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float velocity = 2.5f;
    
    void Start()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, Random.Range(0,360)));
        rb2D.AddForce(transform.right*velocity,ForceMode2D.Impulse);
    }

    
    void Update()
    {
        
    }
}
