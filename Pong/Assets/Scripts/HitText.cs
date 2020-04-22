using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitText : MonoBehaviour
{
    public Animator animator;
    public Text text;
    int hitsInRow;
    public GameObject PoofPrefab;
    public GameObject powerUpPrefab;
    public Transform Pos;

    public void HitBad()
    {
        hitsInRow++;

        if (hitsInRow > 1)
        {
            text.text = hitsInRow + "X!";
            animator.SetBool("Hit", true);
            StartCoroutine(SpawnPowerUp());
        }
    }

    public void HitPaddle()
    {
        hitsInRow = 0;
        animator.SetBool("Hit", false);
    }

    public void Win()
    {
        text.text = "You Win!!!";
        animator.SetBool("Hit", true);
    }

    public void Lose()
    {
        text.text = "You lose. But You knew that already.";
        animator.SetBool("Hit", true);
    }

    IEnumerator SpawnPowerUp()
    {
        
        Pos.position = new Vector3(Random.Range(-40, 40) / 10, 2, 0);
        yield return new WaitForSeconds(Random.Range(1, 3));
        GameObject Poof = Instantiate(PoofPrefab, Pos.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(powerUpPrefab, Pos.position, Quaternion.identity);
        Destroy(Poof, 2);
    }
}
