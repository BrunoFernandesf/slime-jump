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

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Aplica a movimentação a posição atual
            rb.velocity = new Vector2(0.0f, velocidade) ;
        }

        //Valida a posição para pausar o jogo (Game Over)
        if(transform.position.y < -6)
        {
            GamePause();
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Restart();
            }
        }
    }

    public void GamePause()
    {
        Time.timeScale = 0;
    }

    //Reseta o jogo ao ser chamada
    public void Restart()
    {
        transform.position = new Vector3(0, 1, 0);
        Time.timeScale = 1;
    }
}
