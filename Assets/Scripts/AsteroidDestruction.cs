using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestruction : MonoBehaviour
{
    public GameObject prefab;
    public Rigidbody2D rb2D;
    private float scaleChange = 0.75f, scaleLimit = 0.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Shoot"){  
            if(transform.localScale.x - scaleChange > scaleLimit && transform.localScale.y - scaleChange > scaleLimit){
                transform.localScale = new Vector3(transform.localScale.x - scaleChange, transform.localScale.y - scaleChange, 1.0f);
                Instantiate(prefab, transform.position, transform.rotation);
                Instantiate(prefab, transform.position, transform.rotation);
            }            
            Destroy(other.gameObject);            
            Destroy(gameObject);
        }
    }
}
