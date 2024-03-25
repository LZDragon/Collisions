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

public class Collectable : MonoBehaviour
{
    [SerializeField] private int scoreValue = 20;
    [SerializeField] private GameUI gameUI;
    private void OnTriggerEnter(Collider other)
    {
        gameUI.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
