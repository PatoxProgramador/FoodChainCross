using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public void EnoughTime()
    {

        SceneManager.LoadScene("FirstLevel");

    }

}
