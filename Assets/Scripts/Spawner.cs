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

    void Start(){

        StartCoroutine(Spawn());
        
    }

    // Update is called once per frame
    void Update(){


        
    }

    private IEnumerator Spawn(){

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn){

            yield return wait;

            Image a = Instantiate(enemyPrefab, transform.localPosition, Quaternion.identity) as Image;
            a.transform.SetParent(GameObject.FindGameObjectWithTag("SP").transform,false);

        }

    }

}
