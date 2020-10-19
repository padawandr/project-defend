﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float speed;

    //variaveis para efeitos sonoros
   // public AudioClip sfxHit;
  //  public AudioController audioController;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "inimigo") {
            Destroy(this.gameObject);
            //audioController.ToqueSFX(sfxHit);
        }
    }

}
