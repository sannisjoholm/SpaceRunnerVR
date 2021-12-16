using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static GameManager inst;
    public Text scoreText;

    public static List<HighScoreEntry> scores = new List<HighScoreEntry>();

    // Start is called before the first frame update
    public void ScoreOutPut()
    {
        score++;
        scoreText.text = $"Score: {score}";
        PlayerPrefs.SetInt("score", score);
        score = PlayerPrefs.GetInt("score");
        

    }

    public static void Save()
    {
        XMLManager.instance.SaveScores(scores);
    }

    public static void Load()
    {
        scores = XMLManager.instance.LoadScores();
    }

    void Start()
    {
        
    }

    public static void AddNewScore(string entryName, int entryScore)
    {
        scores.Add(new HighScoreEntry { name = entryName, score = entryScore });
    }
    private void Awake()
    {
        inst = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
