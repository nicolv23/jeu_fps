using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    // Création des variables pour la vie du Joueur
    public float vie = 100;
    public Text healthText;

    

    public GameManager gameManager;


    // Cette méthode permet au joueur de prendre des domages 
    //et de relancer le jeu quand sa vie tombe à 0

    

    public void Hit(float damage)
    {
        vie -= damage;
        healthText.text = vie.ToString() + " VIE";


        if (vie <= 0)
        {
            gameManager.EndGame();
        }
    }
    
}
