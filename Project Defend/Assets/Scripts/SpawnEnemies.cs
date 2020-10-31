﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] prefabInimigo1;
    public GameObject[] prefabInimigo2;
    public GameObject[] prefabInimigo3;
    public float intervaloSpawn;

    private int pontos;
    private int tipoInimigo;
    public GameController pontuacao;
    private int enemyCount;
    private GameObject[] prefab;

    private void Start()
    {
        pontuacao = FindObjectOfType(typeof(GameController)) as GameController;
        prefab = prefabInimigo1;
        StartCoroutine("spawnInimigo");
        enemyCount = 1;
        pontos = 0;
      
    }

    private void Update()
    {
        

        if (enemyCount == 10)
        {
            intervaloSpawn -= .1F;
            enemyCount = 0;
        }
        if (pontos >= 50)
        {

            tipoInimigo = Random.Range(1, 3);
            if (tipoInimigo == 1)
            {
                prefab = prefabInimigo1;
            }
            if (tipoInimigo == 2)
            {
                prefab = prefabInimigo2;
            }
        }
        if (pontos >= 150)
        {
            tipoInimigo = Random.Range(1, 4);
            if (tipoInimigo == 1)
            {
                prefab = prefabInimigo1;
            }
            if (tipoInimigo == 2)
            {
                prefab = prefabInimigo2;
            }
            if (tipoInimigo == 3)
            {
                prefab = prefabInimigo3;
            }
        }
        
    }
            IEnumerator spawnInimigo()
            {
                yield return new WaitForSeconds(intervaloSpawn);

                GameObject tempInimigo = Instantiate(prefab[Random.Range(0, prefab.Length)]);

                switch (Random.Range(1, 6))
                {
                    case 1: tempInimigo.transform.position = new Vector3(-4, 4, 0); break;
                    case 2: tempInimigo.transform.position = new Vector3(-2, 5, 0); break;
                    case 3: tempInimigo.transform.position = new Vector3(0, 6, 0); break;
                    case 4: tempInimigo.transform.position = new Vector3(2, 5, 0); break;
                    case 5: tempInimigo.transform.position = new Vector3(4, 4, 0); break;
                }

                enemyCount++;
                pontos = pontuacao.score;
                StartCoroutine("spawnInimigo");
            }
}
