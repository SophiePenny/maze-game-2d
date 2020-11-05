using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationrabbit : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite bunnysheet5_1;
    public Sprite bunnysheet5_10;
    public Sprite bunnysheet5_21;
    public Sprite bunnysheet5_31;
    public Sprite bunnysheet5_3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = bunnysheet5_1;

        if(Input.GetKey("w"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = bunnysheet5_10;
        }

        if(Input.GetKey("d"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = bunnysheet5_21;
        }

        if(Input.GetKey("a"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = bunnysheet5_31;
        }

        if(Input.GetKey("s"))
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = bunnysheet5_3;
        }

    }
}