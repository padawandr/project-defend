using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public Vector2 velocidade;
    public float tempoSpawn;
    public float tempoMorte;
    public int pontuacao;
    public int maxHealth = 1;
    public int currentHealth;
    public HealthBar vida;

    private GameController _gc;
    private Animator anim;
    private Rigidbody2D rbody;
    private SpriteRenderer srend;
    private Collider2D col;
    private bool podeAndar;
    private bool estaMorto; 

    private void Start()
    {
        _gc = FindObjectOfType(typeof(GameController)) as GameController;
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        srend = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        col.enabled = false;
        tempoSpawn += Time.time;
        currentHealth = maxHealth;
        vida.SetMaxHealth(maxHealth);

        switch (transform.position.x) {
            case -4: velocidade.x = .32F; break;
            case -2: velocidade.x = .15F; break;
            case 0: velocidade.x = 0; break;
            case 2: velocidade.x = -.15F; break;
            case 4: velocidade.x = -.32F; break;
        }
    }

    private void Update()
    {
        if (!estaMorto && Time.time > tempoSpawn) {
            podeAndar = true;
            col.enabled = true;
            anim.SetBool("nasceu", true);
        }
    }

    private void FixedUpdate()
    {
        if (podeAndar) {
            rbody.MovePosition(rbody.position + velocidade * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "projetil" || other.gameObject.tag == "Player") {
            estaMorto = true;
            podeAndar = false;
            col.enabled = false;
            srend.sortingOrder = 0;
            anim.SetBool("morreu", true);
            TakeDamage(1);
            _gc.addScore(pontuacao);
            Destroy(this.gameObject, tempoMorte);
        }
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        vida.SetHealht(currentHealth);
    }

}
