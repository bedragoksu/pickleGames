using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float agroRange, moveSpeed;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        //distance
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        
        if(distToPlayer < agroRange)
        {
            //chase
            ChasePlayer();

        }
        //????????????
        else
        {
            //stop chasing
            StopChasingPlayer();
        }

    }

    void StopChasingPlayer()
    {
        rb.velocity = Vector2.zero;
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else if (transform.position.x == player.position.x)
        {
            StopChasingPlayer();
        }
        else 
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }
}
