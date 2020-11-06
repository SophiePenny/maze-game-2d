using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmove : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite Dog1_0;
    public Sprite Dog_1_1_0;
    Rigidbody2D rb;
    int timer;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        direction = -10;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Dog1_0;
        timer ++;
        //Debug.Log(timer);
        rb.velocity = new Vector2(direction, 0);
        if (timer > 700)
        {
            direction = -direction;
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Dog_1_1_0;
            timer = 0;
        }
    }
}