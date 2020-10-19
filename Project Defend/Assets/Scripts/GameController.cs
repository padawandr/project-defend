using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text txtScore;

    private int score;

    //variaveis para efeitos sonoros
    public AudioClip sfxHit;
    public AudioController audioController;

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

    public void SfxHit(bool hit)
    {
        audioController.ToqueSFX(sfxHit);
    }
}
