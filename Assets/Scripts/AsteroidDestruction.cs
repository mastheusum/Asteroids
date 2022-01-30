using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestruction : MonoBehaviour
{
    public GameObject prefab;
    public Rigidbody2D rb2D;
    private float scaleChange = 0.75f, scaleLimit = 0.0f;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Shoot"){  
            if(transform.localScale.x - scaleChange > scaleLimit && transform.localScale.y - scaleChange > scaleLimit){
                GameObject obj;
                transform.localScale = new Vector3(transform.localScale.x - scaleChange, transform.localScale.y - scaleChange, 1.0f);
                obj = Instantiate(prefab, transform.position, transform.rotation);
                obj = Instantiate(prefab, transform.position, transform.rotation);
            }
            GameManager.game.AddPoints();
            Camera.main.GetComponent<AudioManager>().AsteroidDestroyed();
            Destroy(other.gameObject);            
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player") {
            // Game Over
            other.gameObject.SetActive(false);
            Invoke("GameOver", 2.0f);
        }
    }

    void GameOver() {
        GameManager.game.GameOver();
    }
}
