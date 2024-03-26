//////////////////////////////////////////////
//Assignment/Lab/Project: Collisions
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrapCollision : MonoBehaviour
{
    [SerializeField] private float trapDamageAmount;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("laser has collided with something");
        if (other.TryGetComponent<HealthComponent>(out HealthComponent otherHealth) )
        {
            Debug.Log("the something has health");
            otherHealth.TakeDamage(trapDamageAmount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
