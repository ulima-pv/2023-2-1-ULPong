using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float SpeedX = -4f;
    public float SpeedY = 0f;
    public float MinSpeedY = -4f;
    public float MaxSpeedY = 4f;

    private void Update() 
    {
        Vector3 newPos = new Vector3(
            transform.position.x + (SpeedX * Time.deltaTime),
            transform.position.y + (SpeedY * Time.deltaTime),
            0f
        );
        transform.position = newPos;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.CompareTag("Paddle"))
        {
            SpeedX = SpeedX * -1f;
            SpeedY = UnityEngine.Random.Range(MinSpeedY, MaxSpeedY);
        }else if (other.transform.CompareTag("Wall"))
        {
            SpeedY = SpeedY * -1f;
        }else if (other.transform.CompareTag("Goal"))
        {
            transform.position = new Vector3(
                0f,
                0f,
                0f
            );
        }
    }
}
