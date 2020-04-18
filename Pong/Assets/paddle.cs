using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    bool onEdge;
    public float bounceForce;
    public float horizanalEffect;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(!onEdge || transform.position.x > 0)
            {
                rb.MovePosition(transform.position + new Vector3(-speed, 0, 0) * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!onEdge || transform.position.x < 0)
            {
                rb.MovePosition(transform.position + new Vector3(speed, 0, 0) * Time.deltaTime);

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Edge")
        {
            onEdge = true;
        }

        if(collision.gameObject.tag == "Ball")
        {
            Rigidbody2D ballrb = collision.gameObject.GetComponent<Rigidbody2D>();
            ballrb.AddForce(new Vector2(rb.velocity.x / horizanalEffect, bounceForce) * Time.deltaTime);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Edge")
        {
            onEdge = false;
        }
    }
}
