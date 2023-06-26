using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    float velocidade = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        if(transform.position.x < -12)
        {
            Destroy(this.gameObject);
        }
    }
}
