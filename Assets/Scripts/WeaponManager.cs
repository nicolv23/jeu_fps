using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Création des variables pour l'arme utilisé
    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;

    //Variable pour qu'en il tire
    public Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ceci active l'animation de l'arme qd il tire
        if (playerAnimator.GetBool("isShooting")) // isShooting est a false
        {
            playerAnimator.SetBool("isShooting", false);
        }

        //Le joueur peut tirer avec le bouton gauche de la souris
        if (Input.GetButtonDown("Fire1")) // ici input (bouton souris gauche) est detecte
        {
           
            Shoot(); //Appel de la methode Shoot
        }
    }

    void Shoot()
    {
        playerAnimator.SetBool("isShooting", true); 

        RaycastHit hit;

        if(Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range))
        {
            //Debug.Log("hit");
            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if(enemyManager != null)
            {
                enemyManager.Hit(damage);
            }
        }
    }
}
