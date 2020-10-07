using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementEsqueletos : MonoBehaviour
{
    private Spawn controleEsqueletos;
    private Rigidbody2D rbody;
    float posX;
    float posY;
    private Animator anim;
    private float tempoFimSpawn;
    private bool fimSpawn;
    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        controleEsqueletos = FindObjectOfType(typeof(Spawn)) as Spawn;
        rand = controleEsqueletos.rand;
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        /*if (controleEsqueletos.rand == 1)
        {
           rbody.velocity = new Vector2(controleEsqueletos.velocidadeEsqueletoX / 3.5f, -controleEsqueletos.velocidadeEsqueletoY);
        }
        if (controleEsqueletos.rand == 2)
        {
            rbody.velocity = new Vector2(controleEsqueletos.velocidadeEsqueletoX / 8, -controleEsqueletos.velocidadeEsqueletoY);
        }
        if (controleEsqueletos.rand == 3)
        {
            rbody.velocity = new Vector2(0, -controleEsqueletos.velocidadeEsqueletoY);
        }
        if (controleEsqueletos.rand == 4)
        {
            rbody.velocity = new Vector2(-controleEsqueletos.velocidadeEsqueletoX / 8, -controleEsqueletos.velocidadeEsqueletoY);
        }
        if (controleEsqueletos.rand == 5)
        {
            rbody.velocity = new Vector2(-controleEsqueletos.velocidadeEsqueletoX / 3.5f, -controleEsqueletos.velocidadeEsqueletoY);
        }*/

        //rbody.isKinematic = false;
        tempoFimSpawn = Time.time + controleEsqueletos.intervaloSpawn;
        fimSpawn = false;
    }
   
    //Condiçao para morte e acerto(trocar "Triangle (1)" pelo nome da flecha UwU.
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Triangle (1)")
        {
            anim.SetBool("Morte", true);
            rbody.isKinematic = false;


              
            Destroy(this.gameObject, controleEsqueletos.intervaloMorte);


        }
    }

    private void Update()
    {
        if(fimSpawn = false && Time.time>tempoFimSpawn )
        {
            anim.SetBool("Spawn", true);
            //rbody.isKinematic = true;
            
            if (rand == 1)
            {
                rbody.velocity = new Vector2(controleEsqueletos.velocidadeEsqueletoX / 3.5f, -controleEsqueletos.velocidadeEsqueletoY);
            }
            if (rand == 2)
            {
                rbody.velocity = new Vector2(controleEsqueletos.velocidadeEsqueletoX / 8, -controleEsqueletos.velocidadeEsqueletoY);
            }
            if (rand == 3)
            {
                rbody.velocity = new Vector2(0, -controleEsqueletos.velocidadeEsqueletoY);
            }
            if (rand == 4)
            {
                rbody.velocity = new Vector2(-controleEsqueletos.velocidadeEsqueletoX / 8, -controleEsqueletos.velocidadeEsqueletoY);
            }
            if (rand == 5)
            {
                rbody.velocity = new Vector2(-controleEsqueletos.velocidadeEsqueletoX / 3.5f, -controleEsqueletos.velocidadeEsqueletoY);
            }
            fimSpawn = true;

        }




    }





}
