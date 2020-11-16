using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringAndHealth : MonoBehaviour
{
    public int score;

    public int currentHealth;

    public int maxHealth = 100;
    public Text ScoreText;
    public HealthBar healthBar;
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }


  //start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 4)
        {
            YouWin();
        }

        if(currentHealth == 0)
        {
            YouLose();
        }
    }

    void YouWin()
    {
        ScoreText.text = "You Win!";
        Time.timeScale = 0f;
    }

    void YouLose()
    {
        ScoreText.text = "You Lose!";
        Time.timeScale = 0f;
    }
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if(collide.gameObject.name == "carrot")
        {
            Destroy(collide.gameObject);
            addscore();
        }

        if(collide.gameObject.name == "fox")
        {
            TakeDamage(20);
        }

        if(collide.gameObject.name == "carrot")
        {
            TakeDamage(-10);
        }

    }
    void addscore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
