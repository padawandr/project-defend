using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject ConfigMenu;

    public void changeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void pokedexScene(string pokedex)
    {
        SceneManager.LoadScene(pokedex);
    }

    public void BackMenu()
    {
        ConfigMenu.SetActive(false);
 
    }

    public void Settngs()
    {
        ConfigMenu.SetActive(true);
    }
}
