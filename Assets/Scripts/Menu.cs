using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Text a;

    public static string winner = "";

    void Start()
    {
        
    }

     void Update()
    {

        if (a != null && (winner.Equals("You Win") || winner.Equals("You Lose")))
        {

            a.text = winner;

        }
       

    }

    public void MenuButton()
    {

        SceneManager.LoadScene("StartScene");

    }

}
