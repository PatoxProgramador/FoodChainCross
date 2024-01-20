using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour{

    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private Image enemyPrefab;

    [SerializeField] private bool canSpawn = true;

    public Canvas canvas;

    Color []lives = { new Color(0,255,0), new Color(255,255,0), new Color(255,0,0) };
    string[] names = { "Green", "Yellow", "Red"}; 

    int ready;

    void Start(){

        StartCoroutine(Spawn());
        
    }

    void Update(){

        ready = Random.Range(0,3);
        
    }

    private IEnumerator Spawn(){

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn){

            yield return wait;

            if (gameObject.tag == "TL")
            {

                Image tL = Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity) as Image;
                tL.transform.SetParent(GameObject.FindGameObjectWithTag("TL").transform, false);
                tL.color = lives[ready];
                tL.tag = names[ready];

            }
            else if (gameObject.tag == "L")
            {

                Image l = Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity) as Image;
                l.transform.SetParent(GameObject.FindGameObjectWithTag("L").transform, false);
                l.color = lives[ready];
                l.tag = names[ready];

            }
            else if (gameObject.tag == "TR")
            {

                Image tR = Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity) as Image;
                tR.transform.SetParent(GameObject.FindGameObjectWithTag("TR").transform, false);
                tR.color = lives[ready];
                tR.tag = names[ready];

            }
            else if (gameObject.tag == "BR")
            {

                Image bR = Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity) as Image;
                bR.transform.SetParent(GameObject.FindGameObjectWithTag("BR").transform, false);
                bR.color = lives[ready];
                bR.tag = names[ready];

            }

        }

    }

}
