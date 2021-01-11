using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Cat");
    }


    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.name == "Coal")
        {
            Debug.Log("in if in COAL - 1 ");
            countCollisions--;

        }
        else if (collision.name == "Gift");
        {
            Debug.Log("in if in GIFT + 1 ");
            countCollisions++;
        }

     
    }

    
    void Update()
    {

    }
}
