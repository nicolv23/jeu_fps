using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Création des variables
    public CharacterController controller;
    public float speed = 8f;

    Vector3 velocity;

    //Ici c'est la gravité que l'on a sur terre
    public float gravity = -9.81f;

    public bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float jump = 2f;

    // Start est appelé avant la première mise à jour de trame
    void Start()
    {

    }

    // La mise à jour est appelée une fois par image
    void Update()
    {
        //Pour gérer les sauts du joeur en fonction de s'il est déjà au sol ou non
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Pour faire en sorte que le player peut toujours aller en avant
        Vector3 move = transform.right * x + transform.forward*z;
        //Pour controller les mouvements du joueur
        controller.Move(move * speed * Time.deltaTime);

        //Pour fixer la gravité
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //Le joueur peut sauter mais en fonction de la gravité
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Ici le joeur ne pourra pas sauter trop haut 
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
    }
}
