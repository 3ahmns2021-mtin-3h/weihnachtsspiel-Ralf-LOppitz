using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
   
    void Start()
    {
        Debug.Log("Gift");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Hallo Josef " + collision.name);
    }

  
    void Update()
    {

    }
}
