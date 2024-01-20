using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static bool start;

    void Start()
    {

        start = false;
        
    }

    void Update()
    {
        
    }

    public void Play()
    {

        start = true;

        Timer.time = 180;

        Menu.winner = "";

        SceneManager.LoadScene("TutorialFirst");
        
    }
    public void Quit()
    {

        Application.Quit();

    }

}
