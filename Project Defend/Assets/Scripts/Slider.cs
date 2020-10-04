using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{

    //Declarando variaveis para a conf. do limite
    public float velocidadeSlider;
    [Header ("Configuração Limite")]
    public float limiteYMaximo;
    public float limiteYMinimo;
    public float limiteXMaximo;
    public float limiteXMinimo;
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Velocidade e botões do slider (mais pra frente será implementado para touchscreen)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rBody.velocity = new Vector2(horizontal * velocidadeSlider, vertical * velocidadeSlider);

        //Ajusta o limite Y
        if(transform.position.y > limiteYMaximo) 
        {
            transform.position = new Vector3(transform.position.x , limiteYMaximo , 0);
        }
        else if(transform.position.y < limiteYMinimo) 
        {
            transform.position = new Vector3(transform.position.x , limiteYMinimo , 0);
        }

        //Ajusta o limite X
        if(transform.position.x > limiteXMaximo) 
        {
            transform.position = new Vector3(limiteXMaximo , transform.position.y , 0);
        }
        else if(transform.position.x < limiteXMinimo) 
        {
            transform.position = new Vector3(limiteXMinimo , transform.position.y , 0);
        }

    }

}
