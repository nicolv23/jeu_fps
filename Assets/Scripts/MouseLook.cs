using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Création des variables pour la caméra du Joueur
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start est appelé avant la première mise à jour de trame
    void Start()
    {
        //Faire en sorte que la souris ne quitte pas la fenêtre de jeu
        Cursor.lockState = CursorLockMode.Locked;
    }

    // La mise à jour est appelée une fois par image
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        //Faire en sorte que le joueur ne peux regarder qu 'à 90 degré et en haut et en bas en bougeant la souris
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Pour changer la position du joueur
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}





