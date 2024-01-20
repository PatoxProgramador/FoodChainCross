using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{

    RectTransform body;

    BoxCollider2D collided;

    Canvas canvas;

    public float width = 100f;
    public float height = 100f;
    
    void Start()
    {

        body = GetComponent<RectTransform>();

        collided = GetComponent<BoxCollider2D>();

        canvas = FindAnyObjectByType<Canvas>();

        body.sizeDelta = new Vector2(width * canvas.scaleFactor, height * canvas.scaleFactor);

        collided.size = body.sizeDelta;
        collided.offset = new Vector2(0, 0);

    }

    
    void Update()
    {
        
    }

}
