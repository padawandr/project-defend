using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityEnemies : MonoBehaviour
{
    private NewBehaviourScript controleEsqueletos;
    private Rigidbody2D rbody;



    // Start is called before the first frame update
    void Start()
    {
        controleEsqueletos = FindObjectOfType(typeof(NewBehaviourScript)) as NewBehaviourScript;

        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("tempEsqueleto").transform.position == (-4, 4, 0))
        {
            rbody.velocity = new Vector2(velocidadeEsqueletoX / 3, -velocidadeEsqueletoY);
        }
        // if (GetComponent<NewBehaviourScript.transform.position> == (-4, 4, 0))
        // {
        //     rbody.velocity = new Vector2(velocidadeEsqueletoX / 3, -velocidadeEsqueletoY);
        //}
        // if (GetComponent<NewBehaviourScript.transform.position> == (-4, 4, 0))
        // {
        //    rbody.velocity = new Vector2(velocidadeEsqueletoX / 3, -velocidadeEsqueletoY);
        // }
        // if (GetComponent<NewBehaviourScript.transform.position> == (-4, 4, 0))
        // {
        //    rbody.velocity = new Vector2(velocidadeEsqueletoX / 3, -velocidadeEsqueletoY);
        // }
        // if (GetComponent<NewBehaviourScript.transform.position> == (-4, 4, 0))
        // {
        //     rbody.velocity = new Vector2(velocidadeEsqueletoX / 3, -velocidadeEsqueletoY);
        // }

    }
}
