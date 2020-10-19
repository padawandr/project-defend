using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioSource audioSourceSFX;
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

    //função para tocar os efeitos sonoros
    public void ToqueSFX(AudioClip clip) {
        audioSourceSFX.clip = clip;
        audioSourceSFX.Play();
    }
}
