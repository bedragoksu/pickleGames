using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    private float timeBTWShots;
    public float startTimeBTWShots;

    public GameObject projectile;
    
    void Start()
    {
        timeBTWShots = startTimeBTWShots;
    }

    
    void Update()
    {
        if(timeBTWShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBTWShots = startTimeBTWShots;
        }else
        {
            timeBTWShots -= Time.deltaTime;
        }

        
    }
}
