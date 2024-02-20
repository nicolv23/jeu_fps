using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{

    // Création des variables pour le joueur et les ennemis
    public GameObject player;
    public Animator enemyAnimator;
    public float damage = 20f;
    public float health = 100f;
    public GameManager gameManager;
    //public AudioClip hitSound;


    //Méthode pour donner des domages a l'enemy et le tuer
    public void Hit(float damage)
    {
        health = health - damage;
        if(health <= 0)
        {
            gameManager.enemiesAlive--;

            //tuer le zombie
            Destroy(gameObject);
        }
    }

    
    // Mettre la variable player dans le tab du GameObject à Player pour lui référer
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Mettre à jour les animations des ennemis
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        if (GetComponent<NavMeshAgent>().velocity.magnitude > 1)
        {
            enemyAnimator.SetBool("isRunning", true);
        }
        else
        {
            enemyAnimator.SetBool("isRunning", false);
        }
    }

    // On appelle cette méthode si les ennemis touchent le joueur pour lui faire perdre de la vie
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<PlayerManager>().Hit(damage);
            
        }
    }
}
