using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float SpeedX = -4f;
    public float SpeedY = 0f;
    public float MinSpeedY = -4f;
    public float MaxSpeedY = 4f;
    public GameManager gameManager;

    private void Start() 
    {
        // Inscribir como observador
        gameManager.OnPauseGame += Pause;
        gameManager.OnRestartGame += Restart;
    }

    private void Restart()
    {
        SpeedX = -4f;
        SpeedY = 0f;
        transform.position = new Vector3(
            0f,
            0f,
            0f
        );
    }

    private void Pause()
    {
        SpeedX = 0f;
        SpeedY = 0f;
    }

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
            if (other.transform.name == "LeftGoal")
            {
                gameManager.Goal(1); // mete gol el de la derecha
            }else
            {   
                gameManager.Goal(0); // mete gol el de la izquierda
            }
        }
    }
}
