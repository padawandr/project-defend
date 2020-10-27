using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text txtScore;

    private int score;

    private void Start()
    {   if (SceneManager.GetActiveScene().name == "GameOver")
        {
            score = Score.score;
        }
        else
        {
            score = 0;
        }
        txtScore.text = score.ToString();
        Time.timeScale = 1f;

    }

    public void addScore(int enemyScore)
    {
        score += enemyScore;
        txtScore.text = score.ToString();
        
        
        Score.score = this.score;
    }
   
}
