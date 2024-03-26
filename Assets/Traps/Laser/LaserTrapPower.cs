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
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(HealthComponent))]
public class LaserTrapPower : MonoBehaviour
{
    private HealthComponent healthComponent;
    // Start is called before the first frame update
    void Start()
    {
        healthComponent = GetComponent<HealthComponent>();
        healthComponent.HandleOnKilled += OnKilled;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            healthComponent.TakeDamage(50);
        }
    }

    void OnKilled()
    {
        LaserBeam[] childrenLaserBeams = GetComponentsInChildren<LaserBeam>();
        foreach (var laserBeam in childrenLaserBeams)
        {
            laserBeam.PowerDown();
        }

    }
    
}
