using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameManager game;
    public GameObject prefab;
    public int rLocation;
    // Start is called before the first frame update
    void Start()
    {
        /* Parâmetros:
            Nome da função
            Tempo de atraso para a primeira chamada da função
            Tempo de atraso entre a chamada atual e a próxima
        */ 
        InvokeRepeating("Spawn", 1f, game.getTime());
    }

    void Spawn(){
        GameObject obj;
        rLocation = Random.Range(0, 4);
        switch (rLocation){
            case 0:
                obj = Instantiate(prefab, new Vector3(-8.5f,4.5f,0.0f), Quaternion.identity);
                obj.GetComponent<AsteroidDestruction>().game = game;
                break;
            case 1:
                obj = Instantiate(prefab, new Vector3(5.0f,4.5f,0.0f), Quaternion.identity);
                obj.GetComponent<AsteroidDestruction>().game = game;
                break;
            case 2:
                obj = Instantiate(prefab, new Vector3(-5.5f,-4.0f,0.0f), Quaternion.identity);
                obj.GetComponent<AsteroidDestruction>().game = game;
                break;
            case 3:
                obj = Instantiate(prefab, new Vector3(-7.0f,-2.0f,0.0f), Quaternion.identity);
                obj.GetComponent<AsteroidDestruction>().game = game;
                break;
        } 
    }
}
