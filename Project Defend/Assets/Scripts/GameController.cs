using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text txtScore;

    public int score;

    private void Start()
    {
        score = 0;
        txtScore.text = score.ToString();
    }

    public void addScore(int enemyScore)
    {
        score += enemyScore;
        txtScore.text = score.ToString();
    }
}
