using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audiosource;

    

    void Start()
    {
        audiosource.clip = playlist[0];
        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
