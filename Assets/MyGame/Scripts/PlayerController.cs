﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  

    public float speed = 10;
    public GameObject player;

    private float moveHorizontal;
    void Start()
    {
        
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * speed;
        moveHorizontal = moveHorizontal * Time.deltaTime;

       // Debug.Log("X axis" + player.GetComponent<Transform>().position.x);
        player.GetComponent<Transform>().position = player.GetComponent<Transform>().position + new Vector3(moveHorizontal, 0, 0);
        
    }
}
