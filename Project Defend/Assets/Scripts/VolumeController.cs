using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setVolume (float sliderValue)
    {
        audioMixer.SetFloat("Music", Mathf.Log10(sliderValue) * 20);
    }
}
