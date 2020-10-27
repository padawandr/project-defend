using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    //controla o volume geral do jogo

    public AudioController audioController;

    float volumeMaster, volumeMusics, volumeFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeMaster(float volume) 
    {
        volumeMaster = volume;
        AudioListener.volume = volumeMaster;
    }

//    public void VolumeMusics(float volume) 
//    {
//        volumeMusics = volume;
//        audioController.audioSourceMusicaDeFundo.volume = volumeMusics;
//    }

//    public void VolumeFX(float volume) 
//    {
//        volumeFX = volume;
//       audioController.audioSourceMusicaDeFundo.volume = volumeFX;
//    }
}
