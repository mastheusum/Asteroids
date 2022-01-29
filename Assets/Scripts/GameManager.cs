using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text txtPoints;
    public float dificult = 1f;
    public float timeBase = 8f;
    private int points = 0;

    public void AddPoints() {
        points += 1;
        txtPoints.text = points.ToString();
    }

    public float getTime() {
        return timeBase / dificult;
    }
}
