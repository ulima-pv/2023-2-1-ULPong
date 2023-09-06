using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed = -4f;

    private void Update() 
    {
        Vector3 newPos = new Vector3(
            transform.position.x + (Speed * Time.deltaTime),
            transform.position.y,
            0f
        );
        transform.position = newPos;
    }
}
