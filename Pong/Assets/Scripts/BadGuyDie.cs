using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyDie : MonoBehaviour
{
    public HealthBar healthBar;
    public int MaxHealth;
    int currentHealth;
    public SpringJoint2D springJoint;
    public Collider2D RightHand;
    public Collider2D LeftHand;
    public GameObject restart;
    public Canvas canvas;
    public HitText hitText;

    private void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);
        currentHealth = MaxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            currentHealth--;
            healthBar.SetHealth(currentHealth);
            hitText.HitBad();

            if(currentHealth == 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        springJoint.enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        LeftHand.enabled = false;
        RightHand.enabled = false;
        Instantiate(restart, transform.position, Quaternion.identity, canvas.transform);
    }
}
