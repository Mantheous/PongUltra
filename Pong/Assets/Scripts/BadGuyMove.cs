using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMove : MonoBehaviour
{
    public SpringJoint2D springJoint;
    public List<Vector2> positions;
    public float timeBetween;
    int number = 0;
    float timer;
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= timeBetween)
        {
            springJoint.connectedAnchor = positions[number];
            timer = 0;
            number++;
            if (number == positions.Count)
            {
                number = 0;
                Debug.Log("Restart");
            }
        }
    }
}
