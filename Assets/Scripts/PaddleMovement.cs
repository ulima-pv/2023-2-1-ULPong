using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movY = Input.GetAxis("Vertical");
        Transform transform = GetComponent<Transform>();
        Vector3 newPos = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y + (speed * movY * Time.deltaTime), -3.75f, 3.75f),
            0f
        );
        transform.position = newPos; // Actualizamos la posicion
    }

    
}
