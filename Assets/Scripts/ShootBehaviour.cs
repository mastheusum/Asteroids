using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{
    public float impulse = 2;
    public Rigidbody2D rig;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rig.AddForce(transform.up * impulse, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // Tansform Shoot World Position in Viewport Position
        Vector3 viewPoint = cam.WorldToViewportPoint(transform.position);
        // if Shoot Viewport Position not in cam rectangle then Destroy game object
        if (!cam.rect.Contains(viewPoint))
            Destroy(gameObject);
    }
}
