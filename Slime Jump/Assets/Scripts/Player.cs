using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float velocidade = 5.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }   

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //Aplica a movimentação a posição atual
            rb.MovePosition(transform.position + new Vector3(0, 1, 0) * velocidade * Time.deltaTime);
        }
    }
}
