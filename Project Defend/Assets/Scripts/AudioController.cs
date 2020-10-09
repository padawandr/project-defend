using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioClip[] musicasDeFundo;

    void Start()
    {
        //Escolhe aleatóriamente a música de fundo em uma array
        int IndexDaMusicaDeFundo = Random.Range(0, musicasDeFundo.Length);
        //Toca a música
        AudioClip musicaGamePlay = musicasDeFundo[IndexDaMusicaDeFundo];
        audioSourceMusicaDeFundo.clip = musicaGamePlay;
        audioSourceMusicaDeFundo.Play();
    }
}
