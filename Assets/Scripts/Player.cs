using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

    RectTransform b;

    Canvas canvas;

    float movementX;

    void Start()
    {

        canvas = FindAnyObjectByType<Canvas>();

        b = GetComponent<RectTransform>();

        transform.localPosition = new Vector2(0,0);

        //sizing the images with the canvas size;
        b.sizeDelta = new Vector2(100 * canvas.scaleFactor, 100 * canvas.scaleFactor);

        movementX = 1 * canvas.scaleFactor;

        Destroy(gameObject,2);

    }

    void Update()
    {

        transform.Translate(movementX,0,0);
        
    }

}
