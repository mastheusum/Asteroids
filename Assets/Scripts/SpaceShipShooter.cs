using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipShooter : MonoBehaviour
{
    public GameObject shootPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire")) {
            Camera.main.GetComponent<AudioManager>().PlayerShoot();
            GameObject obj = Instantiate(shootPrefab, transform.position, transform.rotation);
        }
    }
}
