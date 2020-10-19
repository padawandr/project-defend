using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] prefabInimigos;
    public float intervaloSpawn;
    
    private int enemyCount;

    private void Start()
    {
        StartCoroutine("spawnInimigo");
        enemyCount = 1;
    }

    private void Update()
    {
        if (enemyCount == 10) {
            intervaloSpawn -= .1F;
            enemyCount = 0;
        }
    }

    IEnumerator spawnInimigo()
    {
        yield return new WaitForSeconds(intervaloSpawn);

        GameObject tempInimigo = Instantiate(prefabInimigos[Random.Range(0, prefabInimigos.Length)]);

        switch (Random.Range(1, 6)) {
            case 1: tempInimigo.transform.position = new Vector3(-4, 4, 0); break;
            case 2: tempInimigo.transform.position = new Vector3(-2, 5, 0); break;
            case 3: tempInimigo.transform.position = new Vector3(0, 6, 0); break;
            case 4: tempInimigo.transform.position = new Vector3(2, 5, 0); break;
            case 5: tempInimigo.transform.position = new Vector3(4, 4, 0); break;
        }

        enemyCount++;
        StartCoroutine("spawnInimigo");
    }
}
