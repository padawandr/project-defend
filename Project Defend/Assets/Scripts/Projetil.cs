using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{

    public float speed;
    public float lifeTime;

    public int dano;
    public float distancia;
    public LayerMask layerInimigo;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        //Dar dano no inimigo
        //RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.forward, distancia, layerInimigo);

        /* if(hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Inimigo"))
            {
                hitInfo.collider.GetComponent<NomeDoScriptDoInimigo>().TakeDamage(dano);
            }

            DestruirProtejil();
        } */


    }

}
