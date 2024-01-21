using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSong : MonoBehaviour
{

    public AudioSource music; 

    void Start()
    {

        music.Play();
        
    }

    void Update()
    {

        if(StartGame.start == true)
        {

            music.mute = true;

        }
        else
        {

            music.mute = false;

        }
        
    }

}
