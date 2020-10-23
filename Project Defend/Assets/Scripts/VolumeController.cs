using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    //controla o volume geral do jogo

    float volumeMaster;
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
}
