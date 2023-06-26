using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataforma : MonoBehaviour
{
    public GameObject Plataforma;
    
    void Start()
    {
        StartCoroutine(SpawnPlataform());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnPlataform()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(Plataforma, new Vector3(12, 0, 0), Quaternion.identity);
        }
    }
    
}
