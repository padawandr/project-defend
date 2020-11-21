using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] prefabInimigo1;
    public GameObject[] prefabInimigo2;
    public GameObject[] prefabInimigo3;
    public float intervaloSpawn;

    public int pontos;
    private int tipoInimigo;
    private GameController pontuacao;
    private int enemyCount;
    private GameObject[] prefab;//prefab que ira assumir a forma de algum dos outros randomicamente

    private void Start()
    {
        pontuacao = FindObjectOfType(typeof(GameController)) as GameController;//acesso da pontuação no script "Game Controller"
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
        if (pontos >= 50)//randomização de inimigos a partir de certa potuação
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
        if (pontos >= 150)//randomização de inimigos a partir de certa pontuação
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

                switch (Random.Range(1, 6))//randomização de posição de spawn
                {
                    case 1: tempInimigo.transform.position = new Vector3(-4, 4, 0); break;
                    case 2: tempInimigo.transform.position = new Vector3(-2, 5, 0); break;
                    case 3: tempInimigo.transform.position = new Vector3(0, 6, 0); break;
                    case 4: tempInimigo.transform.position = new Vector3(2, 5, 0); break;
                    case 5: tempInimigo.transform.position = new Vector3(4, 4, 0); break;
                }

                enemyCount++;
                pontos = pontuacao.score;//iguala a variavel de controle de spawn com a pontuação atual.
                StartCoroutine("spawnInimigo");
            }
}
