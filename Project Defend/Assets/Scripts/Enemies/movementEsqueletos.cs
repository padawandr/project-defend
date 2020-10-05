using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementEsqueletos : MonoBehaviour
{
    private Spawn controleEsqueletos;
    private Rigidbody2D rbody;
    float posX;
    float posY;


    // Start is called before the first frame update
    void Start()
    {
        controleEsqueletos = FindObjectOfType(typeof(Spawn)) as Spawn;

        rbody = GetComponent<Rigidbody2D>();

        
        if (controleEsqueletos.rand == 1)
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
        }
    }
   
    //Condiçao para morte e acerto(trocar "Triangle (1)" pelo nome da flecha UwU.
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Triangle (1)")
        {
            Destroy(this.gameObject);
        }
    }
    
    


}
