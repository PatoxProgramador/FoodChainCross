using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{

    public string scene;

    public Image a;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (a == null)
        {

            SceneManager.LoadScene(scene);

        }
        
    }
}
