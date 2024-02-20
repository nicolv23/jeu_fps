using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Creation de variables
    public int enemiesAlive = 0;

    public int round = 0;

    public GameObject[] spawnPoints;

    public GameObject enemyPrefab;

    public Text roundNumber;
    public Text roundsSurvived;

    public GameObject endScreen;
    
    

    // Compter combien d'ennemis restent avant de passer à la prochaine vague
    void Update()
    {
        if(enemiesAlive == 0)
        {
            round++;
            NextWave(round);
            roundNumber.text = "Vague : " + round.ToString();
        }
    }

    // Méthode pour aller à la prochaine vague d'ennemis après éliminer les Zombies
    public void NextWave(int round)
    {

        for(var x = 0; x< round; x++)
        {
            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject enemySpawned = Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();
            enemiesAlive++;

        }
        
    }
    // Recommencer une nouvelle partie
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }


    // Retourner au Menu Principal
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuXplosur");
    }

    // Partie terminé si la vie du Joueur tombe à 0
    public void EndGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        endScreen.SetActive(true);
        roundsSurvived.text = round.ToString();
    }
}
