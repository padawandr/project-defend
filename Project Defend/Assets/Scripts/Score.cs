using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score;
    private  int scoreMax;
    public Text txtScoreMax;

    // Start is called before the first frame update
    void Start()
    {
        scoreMax = 0;
        if (PlayerPrefs.HasKey("score"))
        {
            scoreMax = PlayerPrefs.GetInt("score");
        }
        txtScoreMax.text = scoreMax.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CheckScore();
    }

    void CheckScore()
    {
        if(score > scoreMax)
        {
            scoreMax = score;
            PlayerPrefs.SetInt("score", scoreMax);
        }
        txtScoreMax.text = scoreMax.ToString();
    }

    public void MaxScore(int enemyScore)
    {
        CheckScore();

        scoreMax += enemyScore;
        txtScoreMax.text = scoreMax.ToString();
    }
}
