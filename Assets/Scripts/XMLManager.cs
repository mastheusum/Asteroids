using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Xml.Serialization;

public class XMLManager : MonoBehaviour
{
    public static XMLManager instance;
    public LeaderBoard leaderBoard;

    void Awake() {
        instance = this;

        if (!Directory.Exists(Application.persistentDataPath + "/HighScores/")) {
            Directory.CreateDirectory(Application.persistentDataPath + "/HighScores/");
        }
        //print(Application.persistentDataPath); para saber onde o XML está sendo salvo
    }

    public void SaveScores(List<HighScoreEntry> scoresToSave) {
        leaderBoard.list = scoresToSave;
        XmlSerializer serializer = new XmlSerializer(typeof(LeaderBoard));
        FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Create);
        serializer.Serialize(stream, leaderBoard);
        stream.Close();
    }

    public List<HighScoreEntry> LoadScores()
    {
        if (File.Exists(Application.persistentDataPath + "/HighScores/highscores.xml"))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LeaderBoard));
            FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Open);
            leaderBoard = serializer.Deserialize(stream) as LeaderBoard;
            stream.Close();
        }

        return leaderBoard.list;
    }

    [System.Serializable]
    public class LeaderBoard
    {
        public List<HighScoreEntry> list = new List<HighScoreEntry>();
    }    
}
