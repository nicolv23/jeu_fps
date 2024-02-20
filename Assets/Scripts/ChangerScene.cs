using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void demarrerAzos() {
        SceneManager.LoadScene("Jeu3D");
    }

    public void demarrerXploSur() {
    SceneManager.LoadScene("Game");
}

    public void quitterJeu()
    {
        Application.Quit();
    }

    public void infosJeuAzos()
    {
        SceneManager.LoadScene("InfosJeuAzos"); 
    }

    public void infosJeuXplosur()
    {
        SceneManager.LoadScene("InfosJeuXplosur"); ;
    }

    public void menuAzos()
    {
        SceneManager.LoadScene("MenuAzos");
    }

    public void menuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void menuXplosur()
    {
        SceneManager.LoadScene("MenuXplosur"); 
    }
}
