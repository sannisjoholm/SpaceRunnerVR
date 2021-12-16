using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public static int Score { get; private set; }

    public int score = GameManager.score;

    public void Awake()
    {
        Instance = this;
    }

    //IncreaseScorea ei tarvita
}
