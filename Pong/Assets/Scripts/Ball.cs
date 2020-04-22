using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int ballLives;
    public Vector2 spawnPoint;
    public Animator animator;
    public HealthBar healthBar;
    bool Spawning;
    public GameObject restart;
    public Canvas canvas;
    public HitText hitText;
    public bool MainBall;

    private void Start()
    {
        if(MainBall)
            healthBar.SetMaxHealth(ballLives);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Lava" && !Spawning)
        {
            if (MainBall)
                StartCoroutine(Spawn());
            else
                Destroy(gameObject);
        }

            
    }

    IEnumerator Spawn()
    {
        Spawning = true;
        animator.SetBool("Death", true);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameObject.GetComponent<Rigidbody2D>().rotation = 0;
        ballLives--;
        healthBar.SetHealth(ballLives);
        yield return new WaitForSeconds(1f);
        if(ballLives != 0)
        {
            transform.position = spawnPoint;
            animator.SetBool("Death", false);
        }else
        {
            Instantiate(restart, transform.position, Quaternion.identity, canvas.transform);
            Destroy(gameObject);
            hitText.Lose();
        }
        Spawning = false;
    }

    public void AddHealth()
    {
        ballLives++;
        healthBar.SetHealth(ballLives);
    }
}
