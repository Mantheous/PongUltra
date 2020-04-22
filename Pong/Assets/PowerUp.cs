using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    int behavoir;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        behavoir = Random.Range(1, 2);
        animator.SetInteger("powerUp", behavoir);
        transform.position = new Vector3(Random.Range(-40, 40) / 10, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(behavoir == 1)
        {

        }
    }
}
