using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    Rigidbody2D rb2d;
    private int count = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce(movement * 8);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            count++; //zwiêksz wartoœæ o 1
            Destroy(collision.gameObject);
            UpadateScoreText();
        }
    }

    void UpadateScoreText() 
    {
        scoreText.text = "Wynik: " + count;
    }


}

