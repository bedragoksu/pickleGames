using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float range;
    private Vector2 target;
    
    void Start()
    {
        target = new Vector2(x: transform.position.x + range, y: transform.position.y);
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
        }
    }
    private void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    

  
}

