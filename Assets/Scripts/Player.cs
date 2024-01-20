using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

    RectTransform b;

    Canvas canvas;
    BoxCollider2D collided;

    public float size;

    public float speed;

    float movementX;

    public float despawn = 3;

    void Start()
    {

        canvas = FindAnyObjectByType<Canvas>();

        b = GetComponent<RectTransform>();

        collided = GetComponent<BoxCollider2D>();

        transform.localPosition = new Vector2(0,0);

        //sizing the images with the canvas size;
        b.sizeDelta = new Vector2(size * canvas.scaleFactor, size * canvas.scaleFactor);

        collided.size = b.sizeDelta;
        collided.offset = new Vector2(0,0);

        movementX = speed * canvas.scaleFactor;

        Destroy(gameObject,despawn);

    }

    void Update()
    {

        transform.Translate(movementX,0,0);
        
    }

}
