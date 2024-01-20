using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField] Text timer;

    public static float time;

    string display;

    int minutes, seconds;

    Text ending;

    bool lose;

    private void Awake()
    {

        GameObject[] nomad = GameObject.FindGameObjectsWithTag("Menu");

        if (nomad.Length > 1)
        {

            Destroy(this.gameObject);

        }

        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {

        time = 180;

        lose = false;

    }

    void Update()
    {

        if (time > 0) 
        {

            time -= Time.deltaTime;

        }
        else if(time <= 0 && lose == false)
        {

            StartGame.start = false;

            Menu.winner = "You Lose";

            SceneManager.LoadScene("EndScene");

            lose = true;

        }

        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);

        display = "Time left: " + string.Format("{0:00}:{1:00}", minutes, seconds);

        timer.text = display;

    }

}
