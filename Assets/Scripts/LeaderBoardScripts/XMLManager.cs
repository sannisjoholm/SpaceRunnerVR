using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.IO;

[System.Serializable]
public class XMLManager : MonoBehaviour
{
    public static XMLManager instance;
    public LeaderBoard leaderboard;

    //C:\Users\your_user\AppData\LocalLow\DefaultCompany\cowrunner\HighScores
    //C:\Users\sjoho\AppData\LocalLow\DefaultCompany\cowrunner\HighScores

    void Awake()
    {
        instance = this;

        if (!Directory.Exists(Application.persistentDataPath + "/HighScores/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/HighScores/");
        }
    }

    public void SaveScores(List<HighScoreEntry> scoresToSave)
    {
        leaderboard.list = scoresToSave;
        XmlSerializer serializer = new XmlSerializer(typeof(LeaderBoard));
        FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Create);
        serializer.Serialize(stream, leaderboard);
        stream.Close();
    }

    public List<HighScoreEntry> LoadScores()
    {
        if (File.Exists(Application.persistentDataPath + "/HighScores/highscores.xml"))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LeaderBoard));
            FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Open);
            leaderboard = serializer.Deserialize(stream) as LeaderBoard;
        }

        return leaderboard.list;
    }
}
