using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialTime : MonoBehaviour
{

    public float time;

    public string name;

    void Start()
    {

        StartCoroutine(Next(time));
        
    }

    void Update()
    {
        
    }

    IEnumerator Next(float f)
    {

        yield return new WaitForSeconds(f);

        SceneManager.LoadScene(name);

    }

}
