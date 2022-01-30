using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardBehaviour : MonoBehaviour
{
    public GameObject prefabScore;
    // Start is called before the first frame update
    void Start()
    {
        // Mostra a pontuação do jogador 
        Text score = GameObject.FindGameObjectsWithTag("Score")[0].GetComponent<Text>();
        score.text = GameManager.game.GetPoints().ToString();

        // Carrega a tabela com as pontuações, ordena e mostra na tela
        Load();
    }

    /*
        Método responsávle por criar uma table de pontuação, adicionar a pontuação da partida atual
        salvar no XML e recarregar a tabela de pontuação no jogo
    */
    public void Save() {
        List<HighScoreEntry> scores = new List<HighScoreEntry>();
        scores = XMLManager.instance.LoadScores();

        HighScoreEntry newScore = new HighScoreEntry();
        newScore.name = GameObject.Find("PlayerName").GetComponent<InputField>().text;
        newScore.score = GameManager.game.GetPoints();

        scores.Add(newScore);
        XMLManager.instance.SaveScores(scores);

        GameObject.Find("PlayerName").GetComponent<InputField>().enabled = false;

        Load();
    }

    /*
    *   Carregar a tabela de pontuação atual (sem a nova pontuação) e mostrar na tela
    */
    public void Load() {
        List<HighScoreEntry> scores = new List<HighScoreEntry>();
        scores = XMLManager.instance.LoadScores();
        
        scores.Sort(delegate(HighScoreEntry x, HighScoreEntry y)
        {
            if (x.score == null && y.score == null) return 0;
            else if (x.score == null) return -1;
            else if (y.score == null) return 1;
            else return x.score.CompareTo(y.score) * (-1);

        });

        GameObject score;
        
        foreach (var element in scores) {
            score = Instantiate(prefabScore);
            
            score.transform.GetChild(0).GetComponent<Text>().text = element.name;
            score.transform.GetChild(1).GetComponent<Text>().text = element.score.ToString();

            score.transform.SetParent(GameObject.Find("Content").transform, false);
        }
    }
}
