using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Cr�ation des variables pour la cam�ra du Joueur
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start est appel� avant la premi�re mise � jour de trame
    void Start()
    {
        //Faire en sorte que la souris ne quitte pas la fen�tre de jeu
        Cursor.lockState = CursorLockMode.Locked;
    }

    // La mise � jour est appel�e une fois par image
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        //Faire en sorte que le joueur ne peux regarder qu '� 90 degr� et en haut et en bas en bougeant la souris
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Pour changer la position du joueur
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}





