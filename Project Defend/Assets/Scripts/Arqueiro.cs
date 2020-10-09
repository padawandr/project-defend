using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arqueiro : MonoBehaviour
{
    public Transform slider;

    private SceneController _sc;
    private Weapon _weapon;
    private Animator anim;

    private void Start()
    {
        _sc = FindObjectOfType(typeof(SceneController)) as SceneController;
        _weapon = FindObjectOfType(typeof(Weapon)) as Weapon;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetFloat("sliderPosX", slider.position.x);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "inimigo") {
            anim.SetBool("morreu", true);
            _weapon.canShoot = false; 
            StartCoroutine("loadGameOver");
        }
    }

    IEnumerator loadGameOver()
    {
        yield return new WaitForSeconds(2F);
        _sc.changeScene("GameOver");
    }
}
