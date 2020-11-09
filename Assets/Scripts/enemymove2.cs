using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove2 : MonoBehaviour
{
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
        timer ++;
        //Debug.Log(timer);
        rb.velocity = new Vector2(0, direction);
        if (timer > 700)
        {
            direction = -direction;
            timer = 0;
        }
    }
}