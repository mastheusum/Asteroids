using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip shoot;
    public AudioClip destroyed;
    
    public void PlayerShoot() {
        GetComponent<AudioSource>().PlayOneShot(shoot, 1f);
    }

    public void AsteroidDestroyed(){
        GetComponent<AudioSource>().PlayOneShot(destroyed, 1f);
    }
}
