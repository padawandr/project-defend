using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arqueiro : MonoBehaviour
{
    private SceneController _sc;

    private void Start()
    {
        _sc = FindObjectOfType(typeof(SceneController)) as SceneController;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "inimigo") {
            _sc.changeScene("GameOver");
        }
    }
}
