using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    int behavoir;
    public Animator animator;
    paddle paddle;
    Ball ball;
    public GameObject newBall;
    GameObject ballObj;
    // Start is called before the first frame update
    void Start()
    {
        behavoir = Random.Range(1, 5);
        animator.SetInteger("powerUp", behavoir);
        paddle = GameObject.FindGameObjectWithTag("Player").GetComponent<paddle>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        ballObj = GameObject.FindGameObjectWithTag("Ball");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (behavoir == 1)
                paddle.PowerPaddle();
            if (behavoir == 2)
                ball.AddHealth();
            if (behavoir == 3)
                Instantiate(newBall, transform.position, Quaternion.identity);
            if (behavoir == 4)
                ballObj.GetComponent<Rigidbody2D>().gravityScale = 0.125f;
            Destroy(gameObject);
        }
    }

}
