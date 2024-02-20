using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        //Lancer le jeu qui se trouve a la scene 1 
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        //Sortir du jeu
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void InfosJeu()
    {
        SceneManager.LoadScene(1); ;
    }


    public void MenuJeu()
    {
        SceneManager.LoadScene(0);
    }
}
