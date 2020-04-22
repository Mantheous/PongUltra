using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitText : MonoBehaviour
{
    public Animator animator;
    public Text text;
    int hitsInRow;

    public void HitBad()
    {
        hitsInRow++;

        if (hitsInRow > 1)
        {
            text.text = hitsInRow + "X!";
            animator.SetBool("Hit", true);
        }
    }

    public void HitPaddle()
    {
        hitsInRow = 0;
        animator.SetBool("Hit", false);
    }
}
