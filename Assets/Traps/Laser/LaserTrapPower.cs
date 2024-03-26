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
    [SerializeField]private HealthComponent healthComponent;
    private bool inCollider = false;

    private List<GameObject> lasers;

    public List<GameObject> Lasers
    {
        get => lasers;
        set => lasers = value;
    }


    // Start is called before the first frame update
    void Awake()
    {
        healthComponent.HandleOnKilled += OnKilled;
        healthComponent.HandleHealthUpdated += OnHealthUpdate;
    }

    private void OnTriggerEnter(Collider other)
    {
        inCollider = true;

    }

    private void OnTriggerExit(Collider other)
    {
        inCollider = false;
    }

    private void Update()
    {
        if (inCollider && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("boop");
            healthComponent.TakeDamage(50);
        }
    }

    void OnKilled()
    {
        foreach (var laserBeam in lasers)
        {
            laserBeam.GetComponent<LaserBeam>().PowerDown();
        }

    }

    void OnHealthUpdate(float health)
    {
        
    }

}
