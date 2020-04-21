using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handSmack : MonoBehaviour
{
    public float smackForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, smackForce));
        }
    }
}
