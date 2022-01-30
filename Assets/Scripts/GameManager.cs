using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Utilizei o Singleton para usar o GameManager tanto no menu como no jogo
    public static GameManager game;
    public float timeBase = 8f;

    Text txtPoints = null;
    float dificult = 1f;
    int points = 0;

    // Garanto que estarei usando semre o mesmo GameManager
    void Awake()
    {
        if (game != null && game != this) {
            Destroy(gameObject);
        }
        else {
            game = this;
        }
        DontDestroyOnLoad(game);
    }

    public int GetPoints() {
        return points;
    }

    public void AddPoints() {
        points += 1;
        if (txtPoints == null)
            txtPoints = GameObject.FindGameObjectsWithTag("Score")[0].GetComponent<Text>();
        txtPoints.text = points.ToString();
    }

    public float getTime() {
        print(dificult);
        return timeBase / dificult;
    }

    public void ChangeDificult(Dropdown obj) {
        dificult = obj.value + 1;
    }

    public void GameOver() {
        SceneManager.LoadScene("GameOver");
    }
}
