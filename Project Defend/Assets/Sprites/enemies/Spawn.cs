using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{

    [Header("Configuração Inimigos")]
    public int intervalo;
    public GameObject prefabEsqueleto;
    private Rigidbody2D rbody;
    public float velocidadeEsqueletoX;
    public float velocidadeEsqueletoY;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnEnemy");

        // rbody = GetComponent<Rigidbody2D>();
    }


    IEnumerator spawnEnemy()
    {
        yield return new WaitForSeconds(intervalo);
        int rand = Random.Range(1, 6);

        switch (rand)
        {
            case 1:
                GameObject tempEsqueleto = Instantiate(prefabEsqueleto);
                tempEsqueleto.transform.position = new Vector3(-4, 4, 0);

                StartCoroutine("spawnEnemy");
                break;
            case 2:
                GameObject tempEsqueleto1 = Instantiate(prefabEsqueleto);
                tempEsqueleto1.transform.position = new Vector3(-2, 5, 0);                

                StartCoroutine("spawnEnemy");
                break;
            case 3:
                GameObject tempEsqueleto2 = Instantiate(prefabEsqueleto);
                tempEsqueleto2.transform.position = new Vector3(0, 6, 0);               

                StartCoroutine("spawnEnemy");
                break;
            case 4:
                GameObject tempEsqueleto3 = Instantiate(prefabEsqueleto);
                tempEsqueleto3.transform.position = new Vector3(2, 5, 0);               

                StartCoroutine("spawnEnemy");
                break;
            case 5:
                GameObject tempEsqueleto4 = Instantiate(prefabEsqueleto);
                tempEsqueleto4.transform.position = new Vector3(4, 4, 0);               

                StartCoroutine("spawnEnemy");
                break;


        }

    }

}
