using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject prefab;
    public int rLocation;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 3f);
    }

    void Spawn(){
        rLocation = Random.Range(0, 4);
        switch (rLocation){
            case 0:
                Instantiate(prefab, new Vector3(-8.5f,4.5f,0.0f), Quaternion.identity);
                break;
            case 1:
                Instantiate(prefab, new Vector3(5.0f,4.5f,0.0f), Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab, new Vector3(-5.5f,-4.0f,0.0f), Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab, new Vector3(-7.0f,-2.0f,0.0f), Quaternion.identity);
                break;
        }
            
        
    }
}
