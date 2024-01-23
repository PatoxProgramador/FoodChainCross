using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float speed;

    Canvas canvas;

    RectTransform size;

    BoxCollider2D colliding;

    int spriteWidth = 100;
    int spriteHeight = 100;

    int difference = 40;

    Image body;

    public string next;
    public static string copy;

    Text ending;

    public Sprite[] group = new Sprite[3];

    void Start()
    {

        canvas = FindAnyObjectByType<Canvas>();

        size = GetComponent<RectTransform>();

        colliding = GetComponent<BoxCollider2D>();

        body = GetComponent<Image>();

        size.sizeDelta = new Vector2(spriteWidth * canvas.scaleFactor, spriteHeight * canvas.scaleFactor);

        colliding.size = new Vector2((spriteWidth * canvas.scaleFactor) - (difference * canvas.scaleFactor), (spriteHeight * canvas.scaleFactor) - (difference * canvas.scaleFactor));
        colliding.offset = new Vector2(0,0);

        body.sprite = group[0];
        gameObject.tag = "Green";

        copy = next;

    }

    void Update()
    {
        canvas = FindAnyObjectByType<Canvas>();

        float a = Input.GetAxisRaw("Horizontal") * speed * canvas.scaleFactor;

        float b = Input.GetAxisRaw("Vertical") * speed * canvas.scaleFactor;

        transform.Translate(a, b,0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Wall" || collision.tag == "Green" || (gameObject.tag == "Yellow" && collision.tag == "Yellow") || (gameObject.tag == "Red" && collision.tag == "Red") || (gameObject.tag == "Red" && collision.tag == "Yellow")) 
        {

            if ((gameObject.tag == "Yellow" && collision.tag == "Yellow") || (gameObject.tag == "Red" && collision.tag == "Red")|| (gameObject.tag == "Green" && collision.tag == "Green"))
            {

                Destroy(collision.gameObject);

            }

            Destroy(gameObject);

        }
        else if (gameObject.tag == "Green" && collision.tag == "Yellow")
        {

            gameObject.tag = "Yellow";
            body.sprite = group[1];

            Destroy(collision.gameObject);

        }
        else if ((gameObject.tag == "Green" || gameObject.tag == "Yellow") && collision.tag == "Red")
        {

            gameObject.tag = "Red";
            body.sprite = group[2];

            Destroy(collision.gameObject);

        }
        else if (collision.tag == "Win")
        {

            if (next.Equals("EndScene"))
            {

                StartGame.start = false;

                Menu.winner = "You Win";

            }

            SceneManager.LoadScene(next);

        }
        
    }

}
